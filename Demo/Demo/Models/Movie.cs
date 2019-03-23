using System;

namespace Demo.Models
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string[] Cast { get; set; }

        public string[] Genres { get; set; }
    }
}