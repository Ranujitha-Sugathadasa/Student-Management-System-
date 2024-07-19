using Microsoft.AspNetCore.Identity;
namespace StudentManagementApplication.Models
{
	public class ApplicationUser : IdentityUser
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

		// public ApplicationUser()
		// {
		// 	FirstName = string.Empty;
		// 	LastName = string.Empty;
		// }
	}
}

