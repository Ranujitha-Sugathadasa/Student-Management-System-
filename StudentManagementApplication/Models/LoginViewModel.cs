using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementApplication.Models
{
	public class LoginViewModel
	{
        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public LoginViewModel()
		{
            UserName = string.Empty;
            Password = string.Empty;
		}
	}
}

