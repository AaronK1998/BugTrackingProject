
using BugTrackingProject.Models;

namespace BugTrackingProject.Data
{
    public interface IBugDetails
    {
        public List<BugDescription> GetBugDescriptionDetails();
        public void AddBugDescription(BugDescription bugDescription);
        public void UpdateBugDescriptionDetails(BugDescription bugDescription);
        public BugDescription GetBugDescriptionData(int id);
        public void DeleteBugDescription(int id);
    }
}
