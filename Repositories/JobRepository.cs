using Microsoft.EntityFrameworkCore;
using JOB_Tracker.API.Data;
using JOB_Tracker.API.Models;

namespace JOB_Tracker.API.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetAllAsync(int userId)
        {
            return await _context.Jobs
                .Where(j => j.UserId == userId)
                .ToListAsync();
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }

        public async Task AddAsync(Job job)
        {
            await _context.Jobs.AddAsync(job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }

        }

        //public Task UpdateAsync(int id, Job job)
        //{
        //    throw new NotImplementedException();
        //}


        public async Task<IEnumerable<Job>> GetPagedAsync(int pageNumber, int pageSize)
        {
            return await _context.Jobs
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalCountAsync()
        {
            return await _context.Jobs.CountAsync();
        }
    }
}
