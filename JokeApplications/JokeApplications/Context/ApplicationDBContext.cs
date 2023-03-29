using JokeApplications.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JokeApplications.API.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {


        }

        public DbSet<Joke> Jokes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Joke>().HasData(new Joke
            {
                Id = 1,
                SetUp = "A lot of people are shocked by the recent events in NASCAR.",
                PunchLine = "What is often characterized as a very conservative organization has taken a stance against racism. I'm not surprised at all though. To anyone who's been paying attention, from its very beginnings, NASCAR has always been veering to the left.",
                ShareableLink = "https://dotnetmasterruch.blob.core.windows.net/mango/13.jpg",
                Date = DateTime.Now,
                Approved=true,
                NSFW=false,
                Type="Normal",
                AutherId=350
            });
            modelBuilder.Entity<Joke>().HasData(new Joke
            {
                Id = 2,
                SetUp = "I was talking to my physics teacher...",
                PunchLine = "I was talking to my physics teacher...",
                ShareableLink = "https://dadjokes.io/joke/60dd36169d829533ec301e49",
                Date = DateTime.Now,
                Approved = true,
                NSFW = true,
                Type = "Normal",
                AutherId = 351
            });
            modelBuilder.Entity<Joke>().HasData(new Joke
            {
                Id = 3,
                SetUp = "How do you make a tissue dance?",
                PunchLine = "You put a little boogie on it.",
                ShareableLink = "https://dadjokes.io/joke2322/60dd36169d8dfdf29533ec301e49",
                Date = DateTime.Now,
                Approved = true,
                NSFW = false,
                Type = "High",
                AutherId = 352
            });
            modelBuilder.Entity<Auther>().HasData(new Auther
            {
                Id = 350,
                Name="Ruchikesh"
            });
            modelBuilder.Entity<Auther>().HasData(new Auther
            {
                Id = 351,
                Name = "Suresh"
            });
            modelBuilder.Entity<Auther>().HasData(new Auther
            {
                Id = 352,
                Name = "Ramesh"
            });

        }
    }
}
