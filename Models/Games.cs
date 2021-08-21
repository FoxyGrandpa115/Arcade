using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Arcade.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string Imagename { get; set; }//see controller file
        [NotMapped]
        public IFormFile Image { get; set; }
        [Required(
       ErrorMessage = "This field is required")]
        [MinLength(1,
       ErrorMessage = "Title must be at least 1 character")]
        public string Title { get; set; }
        [Required(
       ErrorMessage = "This field is required")]
        public string Description { get; set; }
        public int UserId { get; set; }
        public List<Association> Authors {get;set;}
        [NotMapped]
        public List<Association> Likes {get;set;}
        [NotMapped]
        public List<String> Comments{ get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}