using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Arcade.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [NotMapped]
        public List<String> Hobbies { get; set; }
        [Required(
        ErrorMessage = "This field is required")]
        [MinLength(2,
        ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set; }
        [Required(
        ErrorMessage = "This field is required")]
        [MinLength(2,
        ErrorMessage = "Last Name must be at least 2 characters")]
        public string LastName { get; set; }

        [Required(
        ErrorMessage = "This field is required")]
        [MinLength(3,
        ErrorMessage = "Username must be between 3 and 15 characters")]
        [MaxLength(15,
        ErrorMessage = "Username must be between 3 and 15 characters")]
        public string Username { get; set; }//username
        [Required(
        ErrorMessage = "This field is required")]
        [EmailAddress(
        ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }//email
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }
    }
}
