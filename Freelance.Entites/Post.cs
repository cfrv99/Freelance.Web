using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class Post
    {
        public Post()
        {
            PostDate = DateTime.Now;
            PostSkills = new List<PostSkill>();
            Bids = new List<Bid>();
            Notifications = new List<Notification>();
        }
        public int Id { get; set; }
        public string PostName { get; set; }
        public string PostDescription { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }

        public DateTime PostDate { get; set; }
        public DateTime PostDeadLine { get; set; }
        public List<PostSkill> PostSkills { get; set; }
        public List<Bid> Bids { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Notification> Notifications { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }






    }
}
