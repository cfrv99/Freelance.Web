using System;
using System.Collections.Generic;
using System.Text;

namespace Freelance.Entites
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public List<PostSkill> PostSkills { get; set; }

        public Skill()
        {
            PostSkills = new List<PostSkill>();
        }
       
    }
}
