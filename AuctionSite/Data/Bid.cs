using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionSite.Data
{
    public class Bid
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }

        public Auction Auction { get; set; }

        public SiteUser User { get; set; }

        public DateTime CreatedDateTime { get; set; }    

    }
}
