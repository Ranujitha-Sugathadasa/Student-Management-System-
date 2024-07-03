using System;
namespace StudentManagementApplication.Models
{
	public class Student
	{
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Student()
		{
            Name = string.Empty;
            Gender = string.Empty;
            Courses = new List<Course>();
		}
	}
}

