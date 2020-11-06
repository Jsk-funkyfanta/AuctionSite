using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionSite.Data;

namespace AuctionSite.Contracts
{
    public interface IBidRepository : IRepositoryBase<Bid>
    {
        Task<ICollection<Bid>> GetBidsByAuction (int id);
    }
}
