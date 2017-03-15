using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class dice
    {
        Random random = new Random();
        
        public int roll(int side)
        {
            int roll = random.Next(0, side);
            return roll + 1;
        }

        public int rolls(int nmr, int side)
        {
            int total = 0;
            for (int i = 1; i <=nmr;i++)
            {
                total += roll(side);
            }
            return total;
        }

        public int rollCheck(int skill)
        {
            int rullar = roll(100);
            if (rullar == 100)
            {
                return -2;
            }
            if (skill >= rullar)
            {
                if (skill/10 >= rullar)
                {
                    return 1000+(skill-rullar)*2;
                }
                return skill - rullar;
            }
            int fummel = skill/10 + 90;
            if (skill/10 + 90 <= rullar)
            {
                return -2;
            }

            return -1;

        }

        public int compareCheck(int A, int B)
        {
            int C = A - B;
            if (C <= -9)
            {
                return rollCheck(5);
            }
            if (C >= 9)
            {
                return rollCheck(95);
            }
            return rollCheck(C*5+50);
        }

        public int attrCheck(int attr1, int attr2)
        {
            int skill = (attr1 - attr2)*5 + 50;
            int crit = skill/10;
            int fum = skill/10 + 90;
            if (skill > 95)
            {
                skill = 95;}
            if (skill < 5)
            {
                skill = 5;}
            int rullar = roll(100);
            if (rullar == 100)
            {
                return -2;
            }
            if (skill >= rullar)
            {
                if (crit >= rullar)
                {
                    return 1000 + (skill - rullar) * 2;
                }
                return skill - rullar;
            }
            if (fum <= rullar)
            {
                return -2;
            }

            return -1;

        }
    }
}
