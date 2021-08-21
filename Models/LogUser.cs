using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arcade.Models
{
    public class LoginUser
    {
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}