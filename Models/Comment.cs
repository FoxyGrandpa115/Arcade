using System.ComponentModel.DataAnnotations;
namespace Arcade.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int GameId { get; set; }

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

    }

}