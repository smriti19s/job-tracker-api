using JOB_Tracker.API.Models;

namespace JOB_Tracker.API.Repositories
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetAllAsync(int userId);
        Task<Job> GetByIdAsync(int id);
        Task AddAsync(Job job);
        Task UpdateAsync(int id,Job job);
        Task DeleteAsync(int id);
    }
}
