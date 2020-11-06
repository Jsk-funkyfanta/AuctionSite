using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionSite.Data
{
    public class Auction
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public byte[] Picture { get; set; }

        public int MinBid { get; set; }
            
        public ICollection<Bid> Bids { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime EndDateTime { get; set; }
        
        public SiteUser User { get; set; }
    }
}
