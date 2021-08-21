using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Arcade.Models
{
    //database session
    public class Arcade_Context : DbContext
    {
        public Arcade_Context(DbContextOptions options) : base(options) { }
        // the "Users" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Association> Comments { get; set; }
        public DbSet<Association> Likes { get; set; }

        public DbSet<Association> Associations { get; set; }

    }
}