using Gym_TrackerAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace YourNamespace.Pages
{
    public class CoursesModel : PageModel
    {
        // A mock list of courses to demonstrate functionality
        public List<Course> Course { get; set; }
        public string SearchQuery { get; set; }
        public List<Course> FilteredCourses { get; set; }

        // OnGet() method to initialize the list of courses
        public void OnGet(string searchQuery)
        {
            // Initial list of courses (you can replace this with a database call)
            Course = new List<Course>
            {
                new Course { CID = 1, CourseName = "Jogging", ClassPrice = (int)(decimal)2.99 },
                new Course { CID = 2, CourseName = "Arms", ClassPrice = (int)(decimal)1.99 },
                new Course { CID = 3, CourseName = "Pull Up", ClassPrice =(int)12.99 },
                new Course { CID = 4, CourseName = "Bench", ClassPrice = (int)1.99 },
                new Course { CID = 5, CourseName = "Boxing", ClassPrice =(int)24.99 },
                new Course { CID = 6, CourseName = "MMA", ClassPrice = (int)249.99 },
                new Course { CID = 7, CourseName = "Sprinting", ClassPrice =(int)12.99 },
                new Course { CID = 8, CourseName = "StairMaster", ClassPrice = (int)0.99 }
                };

            // Apply the search query filter if it exists
            if (!string.IsNullOrEmpty(searchQuery))
            {
                SearchQuery = searchQuery;
                FilteredCourses = Course.Where(c => c.CourseName.Contains(searchQuery, System.StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                FilteredCourses = Course;
            }
        }
    }
}