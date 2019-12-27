using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class PostSkill
    {
        public int PostId { get; set; }
        public int SkillId { get; set; }
        public Post Post { get; set; }
        public Skill Skill { get; set; }

    }
}
