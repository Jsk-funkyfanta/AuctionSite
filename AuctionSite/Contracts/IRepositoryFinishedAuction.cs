using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionSite.Data;

namespace AuctionSite.Contracts
{
    public interface IRepositoryFinishedAuction : IRepositoryBase<FinishedAuctions>
    {
        Task<bool> MoveAuction (Auction auction);

    }
}
