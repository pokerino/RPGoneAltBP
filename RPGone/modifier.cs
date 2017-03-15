using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class modifier
    {
        private dice dice = new dice();
        public string name;
        public string type;
        public int STY;
        public int INT;
        public int PER;
        public int SMI;
        public int STO;
        public int FYS;
        public int MST;
        public int miniSTY;
        public int miniFYS;
        public int SBmod;
        public int SBbonus;
        public int KPbonus;
        public int FFbonus;
        public int lvl;
        public string desc;

        public override string ToString()
        {
            return name+ " " +getLVL();
        }

        public modifier(string n)
        {
            name = n;
            type = "basic";
            STY = 0;
            INT = 0;
            PER = 0;
            SMI = 0;
            STO = 0;
            FYS = 0;
            MST = 0;
            miniSTY = 0;
            miniFYS = 0;
            SBmod = 0;
            SBbonus = 0;
            KPbonus = 0;
            FFbonus = 0;
            lvl = 0;
            desc = "";
        }

        public modifier(string n, string t, character sender)
        {
            name = n;
            type = t;
            STY = 0;
            INT = 0;
            PER = 0;
            SMI = 0;
            STO = 0;
            FYS = 0;
            MST = 0;
            SBmod = 0;
            SBbonus = 0;
            KPbonus = 0;
            FFbonus = 0;
            lvl = 0;
            desc = "";

            if (type == "CYB")
            {
                if (name == "Mioplant" || name == "Datajack")
                {
                    desc = "Du kan röra dig på Matrisen";
                }
                else
                {
                    MST -= 1;                    
                }

                if (name == "Hyperaktivator")
                {
                    STY += 5;
                    SMI += 5;
                }
                if (name == "Kompakta muskelfibrer (Vältränad)")
                {
                    if(miniSTY<14)
                        miniSTY = 14;
                    KPbonus = Convert.ToInt32(sender.STO/2);
                }
                if (name == "Muskelaccelerator")
                {
                    SBbonus += 5;
                }
                if (name == "Stålkropp")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int newRoll = dice.rolls(2, 10) + 20;
                        if (newRoll > miniSTY)
                            miniSTY = newRoll;
                    }
                }
                if (name == "Lungor eller Hjärta V")
                {
                    if (miniFYS < 15)
                        miniFYS = 15;
                }        
            }

            if (type == "MUT")
            {
                lvl = 1;
                if (name == "Explosiv")
                {
                    SBmod++;
                }

                if (name == "Höjd: STY")
                {
                    STY += dice.roll(6) + 2;
                }
                if (name == "Höjd: INT")
                {
                    INT += dice.roll(4) + 2;
                }
                if (name == "Höjd: PER")
                {
                    PER += dice.roll(4) + 2;
                }
                if (name == "Höjd: SMI")
                {
                    SMI += dice.roll(4) + 2;
                }
                if (name == "Höjd: STO")
                {
                    STO += dice.roll(4) + 2;
                }
                if (name == "Höjd: FYS")
                {
                    FYS += dice.roll(4) + 2;
                }
                if (name == "Höjd: MST")
                {
                    MST += dice.roll(4) + 2;
                }
                
            }

            if (type == "PSI")
            {
                
            }

            if (type == "ROB")
            {
                if (name == "Extrastyrka")
                {
                    lvl = 1;
                    STY += 5;
                }
                
            }

        }

        private string getLVL()
        {
            if (lvl == 1)
                return "I";
            if (lvl == 2)
                return "II";
            if (lvl == 3)
                return "III";
            if (lvl == 4)
                return "IV";
            if (lvl == 5)
                return "V";
            else
                return "";
        }

        public void addLVL()
        {
            lvl++;

            if (name == "Explosiv")
            {
                SBmod++;
            }

            if (name == "Höjd: STY")
            {
                STY += dice.roll(6) + 2;
            }
            if (name == "Höjd: INT")
            {
                INT += dice.roll(4) + 2;
            }
            if (name == "Höjd: PER")
            {
                PER += dice.roll(4) + 2;
            }
            if (name == "Höjd: SMI")
            {
                SMI += dice.roll(4) + 2;
            }
            if (name == "Höjd: STO")
            {
                STO += dice.roll(4) + 2;
            }
            if (name == "Höjd: FYS")
            {
                FYS += dice.roll(4) + 2;
            }
            if (name == "Höjd: MST")
            {
                MST += dice.roll(4) + 2;
            }
            if (name == "Extrastyrka")
            {
                STY += 5;
            }
        }
    }
}
