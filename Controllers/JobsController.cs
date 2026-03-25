using AutoMapper;
using JOB_Tracker.API.DTOs;
using JOB_Tracker.API.Models;
using JOB_Tracker.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JOB_Tracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobsController(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

       
        [HttpGet]
        public async Task<IActionResult> GetJobs(int userId)
        {
            var jobs = await _jobRepository.GetAllAsync(userId);
            
            if (jobs == null)
                return NotFound();

            var result = _mapper.Map<IEnumerable<JobDtoResponse>>(jobs);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJob(int id)
        {
            var job = await _jobRepository.GetByIdAsync(id);

            if (job == null)
                return NotFound();

            var result = _mapper.Map<JobDtoResponse>(job);

            return Ok(result);
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateJob(CreateJobDtoRequest createJobDto)
        {
            var job = _mapper.Map<Job>(createJobDto);

            await _jobRepository.AddAsync(job);

            var jobDto = _mapper.Map<JobDtoResponse>(job);

            //return Ok(jobDto);
            return CreatedAtAction(nameof(GetJob), new { id = job.Id }, jobDto);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, UpdateJobDto updateJobDto)
        {
            var job = _mapper.Map<Job>(updateJobDto);

            if (job == null)
                return NotFound();

            _mapper.Map(updateJobDto, job);

            await _jobRepository.UpdateAsync(id, job);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var job = await _jobRepository.GetByIdAsync(id);

            if (job == null)
                return NotFound();

            await _jobRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
