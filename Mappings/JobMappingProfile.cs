using AutoMapper;
using JOB_Tracker.API.DTOs;
using JOB_Tracker.API.Models;
using System.Runtime;

namespace JOB_Tracker.API.Mappings
{
    public class JobMappingProfile : Profile
    {
        public JobMappingProfile()

        {
            CreateMap<Job, JobDtoResponse>().ReverseMap();
            CreateMap<Job, CreateJobDtoRequest>().ReverseMap();
            CreateMap<Job, UpdateJobDto>().ReverseMap();
        }


    }
}
