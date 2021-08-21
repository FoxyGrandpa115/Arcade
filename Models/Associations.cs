using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Arcade.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
    }
}