using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    public class Skill
    {
        public abstract class AbstractSkill
        {
            public abstract void Speak();
        }

        public class Up : AbstractSkill
        {
            public override void Speak()
            {
                // 上挑音效
                Console.WriteLine("嘿!!!");
            }
        }

        public class Kill : AbstractSkill
        {
            public override void Speak()
            {
                // 鬼斩音效
                Console.WriteLine("哈!!!");
            }
        }

        public class Knock : AbstractSkill
        {
            public override void Speak()
            {
                // 崩天击音效
                Console.WriteLine("oh yeah !!!");
            }
        }

        public class Suck : AbstractSkill
        {
            public override void Speak()
            {
                // 小吸音效
                Console.WriteLine("oh oh oh!!!");
            }
        }
    }
}
