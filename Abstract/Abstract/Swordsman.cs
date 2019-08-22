using System;
using System.Collections.Generic;
using System.Text;
using static Abstract.Skill;

namespace Abstract
{
    public class Swordsman
    {
        private AbstractSkill skill;

        public Swordsman() { }

        public void Select(AbstractSkill skill)
        {
            this.skill = skill;
        }

        public void Hit()
        {
            skill.Speak();
        }
    }
}
