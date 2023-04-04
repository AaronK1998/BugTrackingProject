using BugTrackingProject.Models;

namespace BugTrackingProject.Data
{
    public interface IBugService
    {
        public List<Bug> GetBugDetails();
        public void AddBug(Bug bug);
        public void UpdateBugDetails(Bug bug);
        public Bug GetBugData(int id);
        public void DeleteBug(int id);
    }
}
