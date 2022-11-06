using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace AirlineManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<AeroPlaneModel> AeroPlaneModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<FlightBookingModel> FlightBookingModels { get; set; }

    }
}
