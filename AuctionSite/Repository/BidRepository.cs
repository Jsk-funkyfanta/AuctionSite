using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionSite.Contracts;
using AuctionSite.Data;

namespace AuctionSite.Repository
{
    public class BidRepository : IBidRepository
    {

        public BidRepository()
        {
            
        }
        public Task<ICollection<Bid>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Bid> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Bid entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Bid entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Bid entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Bid>> GetBidsByAuction(int id)
        {
            throw new NotImplementedException();
        }
    }
}
