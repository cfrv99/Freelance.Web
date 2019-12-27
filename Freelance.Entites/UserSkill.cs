using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class UserSkill
    {
        public UserSkill()
        {
            Posts = new List<Post>();
        }

        public string AppUserId { get; set; }
        public int SkillId { get; set; }
        public AppUser AppUser { get; set; }
        public Skill Skill { get; set; }
        

    }

}
