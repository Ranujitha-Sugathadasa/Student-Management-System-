using System;
using System.Collections;

namespace StudentManagementApplication.Models
{
	public class Course
	{
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
        public Course()
		{
            Name = string.Empty;
            Description = string.Empty;
            Students = new List<Student>();
          
		}
	}
}

