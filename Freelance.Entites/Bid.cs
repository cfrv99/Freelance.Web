using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class Bid
    {

        public Bid()
        {
            BidDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string BidBody { get; set; }
        public decimal BidPrice { get; set; }
        public DateTime BidDate { get; set; }
        public bool IsDone { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }


    }
}
