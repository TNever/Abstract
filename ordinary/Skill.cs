using System;
using System.Collections.Generic;
using System.Text;

namespace ordinary
{
    public class Skill
    {
        public class Up
        {
            public void Speak()
            {
                // 上挑音效
                Console.WriteLine("嘿!!!");
            }
        }

        public class Kill
        {
            public void Speak()
            {
                // 鬼斩音效
                Console.WriteLine("哈!!!");
            }
        }

        public class Knock
        {
            public void Speak()
            {
                // 崩天击音效
                Console.WriteLine("oh yeah !!!");
            }
        }
    }
}
