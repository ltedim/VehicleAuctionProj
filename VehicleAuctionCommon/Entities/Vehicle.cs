﻿using VehicleAuctionCommon.Dtos;
using VehicleAuctionCommon.Enums;
using System.ComponentModel.DataAnnotations;

namespace VehicleAuctionCommon.Entities
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Plate { get; set; }
        public VehicleType TypeId { get; set; }
        public int NumDoors { get; set; }
        public int LoadCapacity { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal StartingBid { get; set; }
        public string Manufacturer { get; set; }

        public VehicleDto ToVehicleDto()
        {
            return new VehicleDto (Id, Plate, TypeId, NumDoors, LoadCapacity, Model, Year, StartingBid, Manufacturer);
        }
    }
}
