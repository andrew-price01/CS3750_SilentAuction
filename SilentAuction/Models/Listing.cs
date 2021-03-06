﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SilentAuction.Models
{
    public class Listing
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Auction")]
        [Display(Name = "Auction")]
        public int AuctionId { get; set; }

        public Auction Auction { get; set; }

        [ForeignKey("Item")]
        [Display(Name = "Item")]
        public int ItemId { get; set; }

        public Item Item { get; set; }

        [Required]
        [Display(Name = "Minimum Bid")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "Money")]
        //https://stackoverflow.com/questions/1165761/decimal-vs-double-which-one-should-i-use-and-when
        public decimal MinimumBid { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "Money")]
        public decimal Increment { get; set; }
    }
}
