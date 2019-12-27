using Freelance.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelance.DAL.Abstract
{
    public interface IBidRepository
    {
        Bid GetBidById(int id);
        IQueryable<Bid> GetBids();

        void Create(Bid entity);
        void Delete(Bid entity);
        void Update(Bid entity);

    }
}
