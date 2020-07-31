using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext // Entity Framework
    {
        // DB명: MovieDBContext => Web.config 에서 connectionStrings 내의 add name과 동일해야 함
        public DbSet<Movie> Movies { get; set; } // Movie table
    }
}