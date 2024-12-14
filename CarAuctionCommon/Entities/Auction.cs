﻿using CarAuctionCommon.Dtos;
using CarAuctionCommon.Enums;

namespace CarAuctionCommon.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime AuctionDateTime{ get; set; }
        public AuctionStatus StatusId { get; set; }
        public int? WinningBid { get; set; }
        public DateTime AuctionScheduledEndDateTime { get; set; }
        public DateTime? AuctionEndDateTime { get; set; }

        public AuctionDto ToAuctionDto()
        {
            return new AuctionDto(Id, CarId, AuctionDateTime, StatusId, WinningBid, AuctionScheduledEndDateTime, AuctionEndDateTime );
        }
    }
}
