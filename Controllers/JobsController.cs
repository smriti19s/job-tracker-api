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

        public JobsController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs(int userId)
        {
            var jobs = await _jobRepository.GetAllAsync(userId);
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJob(int id)
        {
            var job = await _jobRepository.GetByIdAsync(id);

            if (job == null)
                return NotFound();

            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob(Job job)
        {
            await _jobRepository.AddAsync(job);
            return Ok(job);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, Job job)
        {
            if (id != job.Id)
                return BadRequest();

            await _jobRepository.UpdateAsync(job);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            await _jobRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
