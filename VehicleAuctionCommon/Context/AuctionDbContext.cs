﻿using VehicleAuctionCommon.Entities;
using Microsoft.EntityFrameworkCore;

namespace VehicleAuctionCommon.Context
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Auction> Auctions{ get; set; }
        public DbSet<Bid> Bids{ get; set; }
    }
}
