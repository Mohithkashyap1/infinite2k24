using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Movies.Models
{
    public class MovieDb : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieDb() : base("MoviesDB") 
        {
        }
    }
}