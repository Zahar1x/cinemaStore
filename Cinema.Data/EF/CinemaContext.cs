using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinem.Data.Model;

namespace Cinem.Data.EF
{
    internal class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Hall> halls { get; set; }
        public DbSet<HallTypes> hallTypes { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Person> persons { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<PlacesOfSession> placesOfSessions { get; set; }
        public DbSet<Session> sessions { get; set; }
        public DbSet<Ticket> tickets { get; set; }

    }

  
}
