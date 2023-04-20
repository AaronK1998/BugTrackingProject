using BugTrackingProject.Models;

namespace BugTrackingProject.Data
{
    public interface IStoryBoardService
    {
        public List<StoryBoard> GetStoryboardDetails();
        public void AddStoryboard(StoryBoard storyBoard);
        public void UpdateStoryboardDetails(StoryBoard storyBoard);
        public StoryBoard GetStoryboardData(int id);
        public void DeleteStoryboard(int id);
    }
}
