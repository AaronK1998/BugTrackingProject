using BugTrackingProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BugTrackingProject.Data
{
    public class StoryBoardService : IStoryBoardService
    {
        readonly ApplicationDbContext _dbContext = new();

        public StoryBoardService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        

        public void AddStoryboard(StoryBoard storyBoard)
        {
            try
            {
                _dbContext.StoryBoards.Add(storyBoard);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteStoryboard(int id)
        {
            try
            {
                StoryBoard? storyBoard = _dbContext.StoryBoards.Find(id);
                if (storyBoard != null)
                {
                    _dbContext.StoryBoards.Remove(storyBoard);
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

        public StoryBoard GetStoryboardData(int id)
        {
            try
            {
                StoryBoard? storyBoard = _dbContext.StoryBoards.Find(id);
                if (storyBoard != null)
                {
                    return storyBoard;
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

        public List<StoryBoard> GetStoryboardDetails()
        {
            try
            {
                return _dbContext.StoryBoards.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateStoryboardDetails(StoryBoard storyBoard)
        {
            try
            {
                _dbContext.Entry(storyBoard).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
