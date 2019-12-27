using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class AppUser:IdentityUser
    {
        public AppUser()
        {
            UserSkills = new List<UserSkill>();
            Posts = new List<Post>();
            Bids = new List<Bid>();
            Notifications = new List<Notification>();
        }

        public string FullName { get; set; }
        public string Experience { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDay { get; set; }
        public List<UserSkill> UserSkills { get; set; }
        public List<Post> Posts { get; set; }
        public List<Bid> Bids { get; set; }
        public List<Notification> Notifications { get; set; }


    }
}
