using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class skill
    {
        public string name;
        public int b_gcl;
        public int gcl;
        public int cost;
        public string desc;

        public skill()
        {
            
        }

        public skill(string n, int s)
        {
            name = n;
            b_gcl = s;
            gcl = b_gcl;
            cost = 1;
            desc = "";
        }

        public skill(string n, int s, int c)
        {
            name = n;
            b_gcl = s;
            gcl = b_gcl;
            cost = c;
            desc = "";
        }

        public skill(string n, int s, string d)
        {
            name = n;
            b_gcl = s;
            gcl = b_gcl;
            cost = 1;
            desc = d;
        }

        public skill(string n, int s, int c, string d)
        {
            name = n;
            b_gcl = s;
            gcl = b_gcl;
            cost = c;
            desc = d;
        }

        public int add()
        {
            gcl +=5;
            if (name == "Undvika" && gcl > 50)
                cost = 4;
            return checkCost();
        }

        public int remove()
        {
            if (gcl-5 < b_gcl)
                return -1;
            else
            {
                int reCost = checkCost();
                gcl-=5;
                if (name == "Undvika" && gcl < 51)
                    cost = 2;
                return reCost;
            }
        }

        public override string ToString()
        {
            int checker = 27;
            string newString = name;
            if (cost != 1)
                newString += "    x" + cost;
            if (gcl > 99)
                checker--;
            if (gcl < 10)
                checker++;
            while (newString.Length < checker)
            {
                newString += " ";
            }
            newString += gcl + "% ";
            if (gcl > b_gcl)
                newString += "+"+(gcl - b_gcl);
            return newString;
        }

        public int checkCost()
        {
            if (gcl > 20 && gcl < 41)
                return cost * 2;
            if (gcl > 40 && gcl < 61)
                return cost * 3;
            if (gcl > 60 && gcl < 81)
                return cost * 4;
            if (gcl > 80 && gcl < 96)
                return cost * 5;
            if (gcl > 95)
                return cost * 6;
            else
                return cost;
        }
    }
}
