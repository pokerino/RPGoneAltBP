using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class maneuvers
    {
        public string name;
        public string connection;
        public string desc;

        public maneuvers(string n, stridskonst s)
        {
            name = n;
            desc = "Kommer senare";
            connection = s.name;
        }

        public maneuvers(string n, string s)
        {
            name = n;
            desc = "Kommer senare";
            connection = s;
        }

        public override string ToString()
        {
            string newString = "";
            newString += name;
            while (newString.Length < 29)
            {
                newString += " ";
            }
            return newString;
        }
    }
}
