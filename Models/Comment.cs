using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arcade.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }


        [Required(
        ErrorMessage = "This field is required")]
        [MinLength(2,
        ErrorMessage = "Name must be more than 2 characters")]
        [MaxLength(45,
        ErrorMessage = "Too Long!")]
        public string name { get; set; }
        [Required(
        ErrorMessage = "This field is required")]
        [MinLength(2,
        ErrorMessage = "Please make a longer quote...")]
        [MaxLength(45,
        ErrorMessage = "Too Long!")]
        public string comment { get; set; }
        public List<Association> Authors { get; set; }
    }

}