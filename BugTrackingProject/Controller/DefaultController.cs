using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor;
using BugTrackingProject.Data;
using System.Collections;
using BugTrackingProject.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BugTrackingProject.Controller
{
    [ApiController]
    public class DefaultController : ControllerBase
    {
        StoryBoardService db = new StoryBoardService();
        //    OrderContext db = new OrderContext();
        // GET: api/Default
        [HttpPost]
        [Route("api/[controller]")]
        public object Post([FromBody] DataManagerRequest dm)
        {
            IEnumerable data = db.GetAllStoryboards(); //call the method to fetch data from db and return to client
            int count = data.Cast<StoryBoard>().Count();
            return dm.RequiresCounts ? new DataResult() { Result = data, Count = count } : (object)data;
        }

        [HttpPost]
        [Route("api/Default/Add")]
        public void Add([FromBody] CRUDModel<StoryBoard> value)
        {
            db.AddStoryboard(value.Value);
        }

        [HttpPost]
        [Route("api/Default/Update")]
        public void Update([FromBody] CRUDModel<StoryBoard> value)
        {
            db.UpdateStoryboardDetails(value.Value);
        }

        [HttpPost]
        [Route("api/Default/Delete")]
        public void Delete([FromBody] CRUDModel<StoryBoard> value)
        {
            db.DeleteStoryboard(Convert.ToInt32(Convert.ToString(value.Key)));
        }

        [HttpPost]
        [Route("api/Default/Batch")]
        public void Batch([FromBody] CRUDModel<StoryBoard> value)
        {
            if (value.Changed.Count > 0)
            {
                foreach (StoryBoard rec in value.Changed)
                {
                    db.UpdateStoryboardDetails(rec);
                }
            }
            if (value.Added.Count > 0)
            {
                foreach (StoryBoard rec in value.Added)
                {
                    db.AddStoryboard(rec);
                }
            }
            if (value.Deleted.Count > 0)
            {
                foreach (StoryBoard rec in value.Deleted)
                {
                    db.DeleteStoryboard(rec.StoryBoardId);
                }
            }
        }

        public class CRUDModel<T> where T : class
        {

            [JsonProperty("action")]
            public string Action { get; set; }
            [JsonProperty("table")]
            public string Table { get; set; }
            [JsonProperty("keyColumn")]
            public string KeyColumn { get; set; }
            [JsonProperty("key")]
            public object Key { get; set; }
            [JsonProperty("value")]
            public T Value { get; set; }
            [JsonProperty("added")]
            public List<T> Added { get; set; }
            [JsonProperty("changed")]
            public List<T> Changed { get; set; }
            [JsonProperty("deleted")]
            public List<T> Deleted { get; set; }
            [JsonProperty("params")]
            public IDictionary<string, object> Params { get; set; }
        }
    }
}
