using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class yrke
    {
        private dice dice = new dice();

        public string name;
        public int indexKey;
        public IList<int> skillList;
        public IList<int> combatSkillList;
        public bool strKstEnable;

        public yrke(int nmr)
        {
            if (nmr == 0)
            {
                name = "Gatubarn";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(5);
                skillList.Add(6);
                skillList.Add(8);
                skillList.Add(9);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(16);
                skillList.Add(17);
                skillList.Add(18);
                skillList.Add(27);

                combatSkillList = new List<int>();
                combatSkillList.Add(4);
                combatSkillList.Add(5);
                combatSkillList.Add(6);
                combatSkillList.Add(8);
                combatSkillList.Add(12);

                strKstEnable = true;
            }
            if (nmr == 1)
            {
                name = "Kriminell";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(2);
                skillList.Add(5);
                skillList.Add(6);
                skillList.Add(8);
                skillList.Add(9);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(16);
                skillList.Add(17);
                skillList.Add(18);
                skillList.Add(25);
                skillList.Add(27);
                skillList.Add(28);

                combatSkillList = new List<int>();
                combatSkillList.Add(1);
                combatSkillList.Add(3);
                combatSkillList.Add(4);
                combatSkillList.Add(5);
                combatSkillList.Add(6);
                combatSkillList.Add(7);
                combatSkillList.Add(8);
                combatSkillList.Add(12);

                strKstEnable = true;
            }
            if (nmr == 2)
            {
                name = "Merc";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(5);
                skillList.Add(6);
                skillList.Add(9);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(16);
                skillList.Add(17);
                skillList.Add(24);
                skillList.Add(25);
                skillList.Add(28);
                skillList.Add(29);

                combatSkillList = new List<int>();
                for (int i = 0; i < 14; i++)
                {
                    combatSkillList.Add(i);                    
                }

                strKstEnable = true;
            }
            if (nmr == 3||nmr == 4)
            {
                if (nmr == 3)
                    name = "Metropolis";
                if (nmr == 4)
                    name = "Internpolis";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(6);
                skillList.Add(7);
                skillList.Add(9);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(18);
                skillList.Add(24);
                skillList.Add(25);

                combatSkillList = new List<int>();
                for (int i = 0; i < 14; i++)
                {
                    combatSkillList.Add(i);
                }

                strKstEnable = true;
            }
            if (nmr == 5 || nmr == 6)
            {
                if (nmr == 5)
                    name = "SVOT";
                if (nmr == 6)
                    name = "Syndikat-SVOT";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(3);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(16);
                skillList.Add(25);
                skillList.Add(26);

                combatSkillList = new List<int>();
                for (int i = 0; i < 14; i++)
                {
                    combatSkillList.Add(i);
                }

                strKstEnable = true;
            }
            if (nmr == 7)
            {
                name = "Gatugladiator";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(0);
                skillList.Add(5);
                skillList.Add(6);
                skillList.Add(9);
                skillList.Add(11);
                skillList.Add(16);
                skillList.Add(29);

                combatSkillList = new List<int>();
                combatSkillList.Add(2);
                combatSkillList.Add(5);
                combatSkillList.Add(9);
                combatSkillList.Add(10);
                combatSkillList.Add(11);
                combatSkillList.Add(12);

                strKstEnable = true;
            }
            if (nmr == 8)
            {
                name = "Mud";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(6);
                skillList.Add(7);
                skillList.Add(8);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(16);
                skillList.Add(21);
                skillList.Add(22);
                skillList.Add(29);

                combatSkillList = new List<int>();
                combatSkillList.Add(2);
                combatSkillList.Add(6);
                combatSkillList.Add(7);
                combatSkillList.Add(12);

                strKstEnable = false;
            }
            if (nmr == 9||nmr == 10)
            {
                if(nmr==9)
                    name = "Tekniker";
                if (nmr == 10)
                    name = "Korpare";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(0);
                skillList.Add(1);
                skillList.Add(3);
                skillList.Add(6);
                skillList.Add(7);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(14);
                skillList.Add(15);
                skillList.Add(21);
                skillList.Add(22);
                skillList.Add(25);
                skillList.Add(26);

                combatSkillList = new List<int>();
                combatSkillList.Add(13);

                strKstEnable = false;
            }

            if (nmr == 11)
            {
                name = "Militär";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(7);
                skillList.Add(9);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(16);
                skillList.Add(23);
                skillList.Add(25);

                combatSkillList = new List<int>();
                for (int i = 0; i < 14; i++)
                {
                    combatSkillList.Add(i);
                }

                strKstEnable = true;
            }

            if (nmr == 12)
            {
                name = "Veteran";
                indexKey = nmr;
                skillList = new List<int>();
                skillList.Add(7);
                skillList.Add(10);
                skillList.Add(11);
                skillList.Add(13);
                skillList.Add(16);
                skillList.Add(23);
                skillList.Add(24);
                skillList.Add(28);

                combatSkillList = new List<int>();
                for (int i = 0; i < 14; i++)
                {
                    combatSkillList.Add(i);
                }

                strKstEnable = true;
            }



        }

        public override string ToString()
        {
            return name;
        }

        public string getCybernetik()
        {
            if (indexKey == 1|| indexKey==2)
            {
                int roll = dice.roll(6)+dice.roll(20);
                if (roll == 2)
                    return "Audioaugmentor";
                if (roll == 3)
                    return "Gastfilter";
                if (roll == 4)
                    return "Geigermätare";
                if (roll == 5)
                    return "Gyrokompas";
                if (roll == 6 || roll == 7)
                    return "Hyperaktivator";
                if (roll == 8)
                    return "IR-öga";
                if (roll == 9)
                    return "Kraftsensor";
                if (roll == 10)
                    return "Laserfinger";
                if (roll == 11)
                    return "Lingoterminal";
                if (roll == 12)
                    return "Mikroskopöga";
                if (roll == 13)
                    return "Måttsensor";
                if (roll == 14)
                    return "Radioutrustning";
                if (roll == 15)
                    return "Rötgenöga";
                if (roll == 16)
                    return "Sekundärminne";
                if (roll == 17)
                    return "Sonar";
                if (roll == 18)
                    return "Teleskopöga";
                if (roll == 19)
                    return "Bepansring";
                if (roll == 20)
                    return "Elektroder";
                if (roll == 21)
                    return "Järnhand";
                if (roll == 22)
                    return "Lasersikte";
                if (roll == 23)
                    return "Magnethand";
                if (roll == 24)
                    return "Stålskalle";
                if (roll == 25)
                    return "Infällbara stålklor";
                if (roll == 26)
                    return "Ultrasonar";
            }
            if (indexKey == 3)
            {
                int roll = dice.roll(6);
                if (roll == 1)
                    return "Fotoreceptor";
                if (roll == 2)
                    return "Kompakta muskelfibrer (Vältränad)";
                if (roll == 3)
                    return "Radioutrustning";
                if (roll == 4)
                    return "Metalldetektor";
                if (roll == 5)
                    return "Muskelaccelerator";
                if (roll == 6)
                    return "Tempokalkulator";
            }
            if (indexKey == 4)
            {
                int roll = dice.roll(10);
                if (roll == 1)
                    return "Hyperaktivator";
                if (roll == 2)
                    return "Sonar";
                if (roll == 3)
                    return "Bepansring";
                if (roll == 4)
                    return "Stålskalle";
                if (roll == 5)
                    return "IR-öga";
                if (roll == 6)
                    return "Järnhand";
                if (roll == 7)
                    return "Lasersikte";
                if (roll == 8)
                    return "Muskelaccelerator";
                if (roll == 9)
                    return "Radioutrustning";
                if (roll == 10)
                    return "Elektroder";
            }
            if (indexKey == 5|| indexKey == 6)
            {
                int roll = dice.roll(20)+dice.roll(6);
                if (roll == 2)
                    return "Audioaugmentor";
                if (roll == 3)
                    return "Gasfilter";
                if (roll == 4)
                    return "Gyrokompas";
                if (roll == 5)
                    return "Hyperaktivator";
                if (roll == 6)
                    return "IR-öga";
                if (roll == 7)
                    return "Kompaktfettvävnad";
                if (roll == 8)
                    return "Lungor eller Hjärta V";
                if (roll == 9)
                    return "Måttsensor";
                if (roll == 10)
                    return "Radioutrustning";
                if (roll == 11)
                    return "Röntgenöga";
                if (roll == 12)
                    return "Sonar";
                if (roll == 13)
                    return "Arm/ben kontroller";
                if (roll == 14)
                    return "Bepansring";
                if (roll == 15)
                    return "CAS/CAK";
                if (roll == 16)
                    return "Elektroder";
                if (roll == 17)
                    return "Järnhand";
                if (roll == 18)
                    return "Lasersikte";
                if (roll == 19)
                    return "Muskelaccelerator";
                if (roll == 20)
                    return "Sonardämpare";
                if (roll == 21)
                    return "Stridskoordinator";
                if (roll == 22)
                    return "Stålkropp";
                if (roll == 23)
                    return "Stålskalle";
                if (roll == 24)
                    return "Target lock";
                if (roll == 25)
                    return "Ultrasonar";
                if (roll == 26)
                    return "Ögonprocessor";
            }
            if (indexKey == 7)
            {
                int roll = dice.roll(10);
                if (roll == 1)
                    return "Gyrokompas";
                if (roll == 2)
                    return "Hyperaktivator";
                if (roll == 3)
                    return "Bepansring";
                if (roll == 4)
                    return "Elektroder";
                if (roll == 5)
                    return "Stålklor";
                if (roll == 6)
                    return "Järnhand";
                if (roll == 7)
                    return "Magnethand";
                if (roll == 8)
                    return "Stålkäkar";
                if (roll == 9)
                    return "Stålkropp";
                if (roll == 10)
                    return "Stålskalle";
            }
            if (indexKey == 8)
            {
                int roll = dice.roll(8);
                if (roll == 1)
                    return "Datajack";
                if (roll == 2)
                    return "Mioplant";
                if (roll == 3)
                    return "Fotoreceptor";
                if (roll == 4)
                    return "Teleskopöga";
                if (roll == 5)
                    return "Lingoterminal";
                if (roll == 6)
                    return "Radioutrustning";
                if (roll == 7)
                    return "Tempkalkulator";
                if (roll == 8)
                    return "Sekundärminne";
            }
            if (indexKey == 9)
            {
                int roll = dice.roll(10);
                if (roll == 1)
                    return "Datajack";
                if (roll == 2)
                    return "Mioplant";
                if (roll == 3)
                    return "Gasfilter";
                if (roll == 4)
                    return "Geigermätare";
                if (roll == 5)
                    return "Laserfinger";
                if (roll == 6)
                    return "Mikroskopöga";
                if (roll == 7)
                    return "Måttsensor";
                if (roll == 8)
                    return "Sekundärminne";
                if (roll == 9)
                    return "Tempkalkulator";
                if (roll == 10)
                    return "Röntgenöga";
            }
            if (indexKey == 11)
            {
                int roll = dice.roll(6);
                if (roll == 1)
                    return "Bepansring";
                if (roll == 2)
                    return "Kompakta muskelfibrer (Vältränad)";
                if (roll == 3)
                    return "Radioutrustning";
                if (roll == 4)
                    return "IR-öga";
                if (roll == 5)
                    return "Muskelaccelerator";
                if (roll == 6)
                    return "Hyperaktivator";
            }
            if (indexKey == 12)
            {
                int roll = dice.roll(6);
                if (roll == 1)
                    return "Bepansring";
                if (roll == 2)
                    return "Sonar";
                if (roll == 3)
                    return "Radioutrustning";
                if (roll == 4)
                    return "IR-öga";
                if (roll == 5)
                    return "Stålskalle";
                if (roll == 6)
                    return "Måttsensor";
            }

            return null;
        }
    }
}
