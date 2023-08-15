using Microsoft.EntityFrameworkCore;
using CreekRiver.Models;

public class CreekRiverDbContext : DbContext
{

    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Campsite> Campsites { get; set; }
    public DbSet<CampsiteType> CampsiteTypes { get; set; }

    public CreekRiverDbContext(DbContextOptions<CreekRiverDbContext> context) : base(context)
    {


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // seed data with campsite
        modelBuilder.Entity<Campsite>().HasData(new Campsite[]
        {
         new Campsite {Id = 1, CampsiteTypeId = 1, Nickname = "Barred Owl", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
         new Campsite {Id = 2, CampsiteTypeId = 2, Nickname = "Barred Cat", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
         new Campsite {Id = 3, CampsiteTypeId = 3, Nickname = "Barred Dog", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
         new Campsite {Id = 4, CampsiteTypeId = 4, Nickname = "Barred Rhino", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
         new Campsite {Id = 5, CampsiteTypeId = 5, Nickname = "Barred Alligator", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},
         new Campsite {Id = 6, CampsiteTypeId = 6, Nickname = "Barred Monkey", ImageUrl="https://tnstateparks.com/assets/images/content-images/campgrounds/249/colsp-area2-site73.jpg"},

        });
        // seed data with user profile
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile[] 
        {
            new UserProfile {Id = 1, FirstName = "Bob", LastName = "Dole", Email = "Bob@email.com"}
        });
        // seed data with reservations
        modelBuilder.Entity<Reservation>().HasData(new Reservation[] 
        {
            new Reservation {Id = 1, CampsiteId = 1, UserProfileId = 1, CheckinDate = DateTime.Today, CheckoutDate = DateTime.Today.AddDays(3) }
        });
        // seed data with campsite types
        modelBuilder.Entity<CampsiteType>().HasData(new CampsiteType[]
        {
        new CampsiteType {Id = 1, CampsiteTypeName = "Tent", FeePerNight = 15.99M, MaxReservationDays = 7},
        new CampsiteType {Id = 2, CampsiteTypeName = "RV", FeePerNight = 26.50M, MaxReservationDays = 14},
        new CampsiteType {Id = 3, CampsiteTypeName = "Primitive", FeePerNight = 10.00M, MaxReservationDays = 3},
        new CampsiteType {Id = 4, CampsiteTypeName = "Hammock", FeePerNight = 12M, MaxReservationDays = 7},
        new CampsiteType {Id = 5, CampsiteTypeName = "Straw", FeePerNight = 17M, MaxReservationDays = 5},
        new CampsiteType {Id = 6, CampsiteTypeName = "Rocks", FeePerNight = 5M, MaxReservationDays = 4},
        });

    }
}
