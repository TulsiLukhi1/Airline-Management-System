﻿using Microsoft.EntityFrameworkCore;

namespace AirlineManagementSystem.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        //public AppDbContext() : base("AirlineMS_DBConnection")
        //{

        //}

        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<AeroPlaneModel> AeroPlaneModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<FlightBookingModel> FlightBookingModels { get; set; }
        public DbSet<FlightDetailsModel> FlightDetailsModels { get; set; }

    }
}
