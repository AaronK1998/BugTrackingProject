using BugTrackingProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BugTrackingProject.Data
{
    public class StoryBoardService
    {
        StoryboardContext db = new StoryboardContext();

        //To Get all Orders details   
        public DbSet<StoryBoard> GetAllStoryboards()
        {
            try
            {
                return db.StoryBoards;
            }
            catch
            {
                throw;
            }
        }

        public void AddStoryboard(StoryBoard storyBoard)
        {
            try
            {
                db.StoryBoards.Add(storyBoard);
                db.SaveChanges();
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
                db.Entry(storyBoard).State = EntityState.Modified;
                db.SaveChanges();
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
                StoryBoard story = db.StoryBoards.Find(id);
                return story;
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
                db.StoryBoards.Remove(db.StoryBoards.Where(or => or.StoryBoardId == id).FirstOrDefault());
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
