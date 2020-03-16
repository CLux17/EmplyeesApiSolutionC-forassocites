using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmplyeesApi.Controllers
{
    public class StatusController : Controller
    {
        [HttpGet("/status")]
        public ActionResult GetTheServerStatus()
        {
            var response = new StatusResponse
            {
                Status = "Everything is Running Smoothly",
                CreatedAt = DateTime.Now
            };
            return Ok(response);
        }

        [HttpGet("/blogs/{year:int}/{month:int}/{day:int}")]
        public ActionResult GetBlogPosts(int year, int month, int day)
        {
            return Ok($"Getting you the blog posts for: {month}/{day}/{year}");
        }
    }

    public class StatusResponse
    {
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
