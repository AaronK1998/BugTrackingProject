using BugTrackingProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class BugDetailService : IBugDetails
    {
        private readonly ApplicationDbContext _dbContext = new ();

        public BugDetailService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBugDescription(BugDescription bugDescription)
        {
            try
            {
                _dbContext.BugDescriptions.Add(bugDescription);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteBugDescription(int id)
        {
            try
            {
                BugDescription? bugDescription = _dbContext.BugDescriptions.Find(id);
                if (bugDescription != null)
                {
                    _dbContext.BugDescriptions.Remove(bugDescription);
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

        public BugDescription GetBugDescriptionData(int id)
        {
            try
            {
                BugDescription? bugDescription = _dbContext.BugDescriptions.Find(id);
                if (bugDescription != null)
                {
                    return bugDescription;
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

        public List<BugDescription> GetBugDescriptionDetails()
        {
            try
            {
                return _dbContext.BugDescriptions.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateBugDescriptionDetails(BugDescription bugDescription)
        {
            try
            {
                _dbContext.Entry(bugDescription).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
