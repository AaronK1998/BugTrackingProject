using BugTrackingProject.Models;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class BugService : IBugService
    {
        readonly ApplicationDbContext _dbct = new();

        public BugService(ApplicationDbContext dbContext)
        {
            _dbct = dbContext;
        }

        public void AddBug(Bug bug)
        {
            try
            {
                _dbct.Bugs.Add(bug);
                _dbct.SaveChanges();
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
                Bug? bug = _dbct.Bugs.Find(id);
                if (bug != null)
                {
                    _dbct.Bugs.Remove(bug);
                    _dbct.SaveChanges();
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
                Bug? bug = _dbct.Bugs.Find(id);
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
                return _dbct.Bugs.ToList();
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
                _dbct.Entry(bug).State = EntityState.Modified;
                _dbct.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
