using System;
using System.Collections.Generic;
using System.Text;
using static ordinary.Skill;

namespace ordinary
{
    public class Swordsman
    {
        // 对应的两个技能
        private Up up;
        private Kill kill;
        private Knock knock;
        // 选择释放哪个技能
        public void Select(object skill)
        {
            if (skill is Up)
            {
                up = (Up)skill;
                kill = null;
                knock = null;
            }
            else if(skill is Kill)
            {
                kill = (Kill)skill;
                up = null;
                knock = null;
            }
            else
            {
                knock = (Knock)skill;
                up = null;
                kill = null;
            }
        }

        // 释放不同的技能对应着不同的释放音效
        public void Hit()
        {
            Console.WriteLine("开始打怪!!");
            if (kill == null && knock == null)
            {
                up.Speak();
            }
            else if (up == null && knock == null)
            {
                kill.Speak();
            }
            else
            {
                knock.Speak();
            }
        }
    }
}
