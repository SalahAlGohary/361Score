using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;

namespace _361Score.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Continent> continents { get; set; }
        public DbSet<Competition> competitions { get; set; }
        public DbSet<CompetitionType> competitionTypes { get; set; }
        public DbSet<CompetitionVersion> competitionVersions { get; set; }
        public DbSet<CompetitionCategory> competitionCategories { get; set; }
        public DbSet<TeamCompetition> teamCompetitions { get; set; }
        public DbSet<Modulation> modulations { get; set; }
        public DbSet<MatchList> matchLists { get; set; }
        public DbSet<MatchEvent> matchEvents { get; set; }
        public DbSet<EventTypes> eventTypes { get; set; }
        public DbSet<Statistics> statistics { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Tags> tags { get; set; }
        public DbSet<NewsTags> newsTags { get; set; }
        public DbSet<Standing> standings { get; set; }
        public DbSet<Match> matches { get; set; }
        public DbSet<MatchStatus> matchStatuses { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}