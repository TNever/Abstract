using System;
using static ordinary.Skill;

namespace ordinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化一个鬼剑士旭旭宝宝
            Swordsman xuxubaobao = new Swordsman();

            // 旭旭宝宝选择使用上挑并释放出去
            xuxubaobao.Select(new Up());
            xuxubaobao.Hit();

            // 旭旭宝宝选择使用鬼斩并释放出去
            xuxubaobao.Select(new Kill());
            xuxubaobao.Hit();
            // 旭旭宝宝选择使用崩天击并释放出去
            xuxubaobao.Select(new Knock());
            xuxubaobao.Hit();

        }
    }
}
