using BugTrackingProject.Models;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class BugService : IBugService
    {
        private readonly ApplicationDbContext _dbContext = new();

        public BugService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBug(Bug bug)
        {
            try
            {
                _dbContext.Bugs.Add(bug);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteBug(int id)
        {
            try
            {
                Bug? bug = _dbContext.Bugs.Find(id);
                if (bug != null)
                {
                    _dbContext.Bugs.Remove(bug);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public Bug GetBugData(int id)
        {
            try
            {
                Bug? bug = _dbContext.Bugs.Find(id);
                if (bug != null)
                {
                    return bug;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Bug> GetBugDetails()
        {
            try
            {
                return _dbContext.Bugs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateBugDetails(Bug bug)
        {
            try
            {
                _dbContext.Entry(bug).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
