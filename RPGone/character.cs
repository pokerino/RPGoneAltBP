using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGone
{
    public class character
    {
        private dice dice = new dice();
        private tabeller tabeller = new tabeller();
        public IList<modifier> modifiers;

        private int baseSTY;
        private int baseINT;
        private int basePER;
        private int baseSMI;
        private int baseSTO;
        private int baseFYS;
        private int baseMST;

        public int STY
        {
            get
            {
                try
                {
                    int getvalue = baseSTY;
                    foreach (modifier element in modifiers)
                        if (element.miniSTY > getvalue)
                            getvalue = element.miniSTY;
                    foreach (modifier element in modifiers)
                        getvalue += element.STY;
                    return getvalue;
                }
                catch
                {
                    return baseSTY;
                }
            }
        }
        public int INT
        {
            get
            {
                try
                {
                    int getvalue = baseINT;
                    foreach (modifier element in modifiers)
                        getvalue += element.INT;
                    return getvalue;
                }
                catch
                {
                    return baseINT;
                }
            }
        }
        public int PER
        {
            get
            {
                try
                {
                    int getvalue = basePER;
                    foreach (modifier element in modifiers)
                        getvalue += element.PER;
                    return getvalue;
                }
                catch
                {
                    return basePER;
                }
            }
        }
        public int SMI
        {
            get
            {
                try
                {
                    int getvalue = baseSMI;
                    foreach (modifier element in modifiers)
                        getvalue += element.SMI;
                    return getvalue;
                }
                catch
                {
                    return baseSMI;
                }
            }
        }
        public int STO
        {
            get
            {
                int getvalue = baseSTO;
                foreach (modifier element in modifiers)
                    getvalue += element.STO;
                return getvalue;
            }
        }
        public int FYS
        {
            get
            {
                int getvalue = baseFYS;
                foreach (modifier element in modifiers)
                    if (element.miniFYS > getvalue)
                        getvalue = element.miniFYS;
                foreach (modifier element in modifiers)
                    getvalue += element.FYS;
                return getvalue;
            }
        }
        public int MST
        {
            get
            {
                int getvalue = baseMST;
                foreach (modifier element in modifiers)
                    getvalue += element.MST;
                return getvalue;
            }
        }

        private int EPmod;

        public string KLASS;
        private IList<string> mutationerString;
        private int[] mutationerInt;
        public IList<skill> skills;
        public IList<skill> combatSkills;
        public stridskonst strKst;
        public IList<skill> psiSkills;
        public int alder;
        private int robAlder;

        public yrke tYrke;

        public int SBroll
        {
            get
            {
                int _SB = STY + STO;
                foreach (modifier element in modifiers)
                {
                    _SB += element.SBbonus;
                }
                int SBtotal = -1;
                if (_SB > 10)
                    SBtotal++;
                if (_SB > 25)
                    SBtotal++;
                if (_SB > 32)
                    SBtotal++;
                if (_SB > 41)
                    SBtotal++;
                if (_SB > 52)
                {
                    int control = STY + STO - 60;
                    while (control > 0)
                    {
                        SBtotal++;
                        control -= 20;
                    } 
                }
                foreach (modifier element in modifiers)
                {
                    SBtotal += element.SBmod;
                }

                if (SBtotal< 0)
                    return -2;
                if (SBtotal == 1)
                    return dice.roll(4);
                if (SBtotal == 2)
                    return dice.roll(6);
                if (SBtotal == 3)
                    return dice.rolls(2, 6);
                if (SBtotal > 3)
                    return dice.rolls(SBtotal-1, 6);
                else return 0;
            }
        }

        public string SB
        {
            get
            {
                int _SB = STY + STO;
                foreach (modifier element in modifiers)
                {
                    _SB += element.SBbonus;
                }
                int SBtotal = -1;
                if (_SB > 10)
                    SBtotal++;
                if (_SB > 25)
                    SBtotal++;
                if (_SB > 32)
                    SBtotal++;
                if (_SB > 41)
                    SBtotal++;
                if (_SB > 52)
                {
                    int control = STY + STO - 60;
                    while (control > 0)
                    {
                        SBtotal++;
                        control -= 20;
                    }
                }
                foreach (modifier element in modifiers)
                {
                    SBtotal += element.SBmod;
                }

                if (SBtotal < 0)
                    return "SB: -2";
                if (SBtotal == 1)
                    return "SB: +1T4";
                if (SBtotal == 2)
                    return "SB: +1T6";
                if (SBtotal == 3)
                    return "SB: +2T6";
                if (SBtotal > 3)
                    return "SB: +" + (SBtotal-1).ToString() + "T6";
                else return "SB: -";
            }
        }

        public character()
        {
            KLASS = "Okänd";
            baseSTY = threeRolls(3, 6);
            baseINT = threeRolls(3, 6);
            basePER = threeRolls(3, 6);
            baseSMI = threeRolls(3, 6);
            baseSTO = threeRolls(3, 6);
            baseFYS = threeRolls(3, 6);
            baseMST = threeRolls(3, 6);
            mutationerString = new List<string>()
            {
                "Elementmotstånd",
                "Energikropp",
                "Smärttålig",
                "Fotosyntetisk hud",
                "Robust",
                "Gälar och simhud",
                "Huggtänder",
                "Kvick",
                "Immunitet: Radioaktivitet",
                "Immunitet: Gifter & gaser",
                "Immunitet: Sjukdomar",
                "Immunitet: Neuro-effekter",
                "Explosiv",
                "Infrasyn",
                "Kameleont",
                "Klor",
                "Multilimb",
                "Löpare",
                "Litet sömnbehov",
                "Skärpta sinnen",
                "Pansarartad hud",
                "Precision",
                "Blodhund",
                "Pyrohali",
                "Spottare",
                "Regeneration",
                "Snabbhet",
                "Feromoner",
                "Sonar",
                "Höjd: STY",
                "Höjd: INT",
                "Höjd: PER",
                "Höjd: SMI",
                "Höjd: STO",
                "Höjd: FYS",
                "Höjd: MST",
                "Giftig",
                "Svans",
                "Vingar",
                "Mimicry"
            };
            mutationerInt = new int[40];
            skills = new List<skill>();
            combatSkills = new List<skill>();
            strKst = new stridskonst(0, SMI+SMI, this);
            alder = 20;
            robAlder = 20;
            EPmod = 5;
            modifiers = new List<modifier>();
            modifiers.Add(new modifier("ageMod"));
        }

        private int threeRolls(int nmr, int sides)
        {
            int newDice = 0;
            for (int i = 0; i < 3; i++)
            {
                int testDice = new int();
                testDice = dice.rolls(nmr, sides);
                if (testDice > newDice)
                {
                    newDice = testDice;
                }
            }
            return newDice;
        }

        public void newAttr()
        {
            mutationerInt = new int[40];
            KLASS = "Okänd";
            baseSTY = threeRolls(3, 6);
            baseINT = threeRolls(3, 6);
            basePER = threeRolls(3, 6);
            baseSMI = threeRolls(3, 6);
            baseSTO = threeRolls(3, 6);
            baseFYS = threeRolls(3, 6);
            baseMST = threeRolls(3, 6);
            psiSkills = new List<skill>();
        }

        public void newAttr(int klass)
        {
            modifiers = new List<modifier>();
            modifiers.Add(new modifier("ageMod"));
            mutationerInt = new int[40];
            EPmod = 5;
            if (klass == 0)
            {
                KLASS = "Människa";
                baseSTY = threeRolls(3, 6);
                baseINT = threeRolls(3, 6);
                basePER = threeRolls(3, 6);
                baseSMI = threeRolls(3, 6);
                baseSTO = threeRolls(3, 6);
                baseFYS = threeRolls(3, 6);
                baseMST = threeRolls(3, 6);
                psiSkills = new List<skill>();
            }
            if (klass == 1)
            {
                KLASS = "Mutant";
                baseSTY = threeRolls(4, 6);
                baseINT = threeRolls(2, 6)+1;
                basePER = threeRolls(2, 6)+1;
                baseSMI = threeRolls(3, 6);
                baseSTO = threeRolls(3, 6)+3;
                baseFYS = threeRolls(3, 6)+1;
                baseMST = threeRolls(2, 6)+1;
                psiSkills = new List<skill>();
                mutationer(dice.roll(4) + 1);
            }
            if (klass == 2)
            {
                KLASS = "PSI-mutant";
                baseSTY = threeRolls(2, 6)+1;
                baseINT = threeRolls(2, 6)+6;
                basePER = threeRolls(3, 6)+1;
                baseSMI = threeRolls(3, 6);
                baseSTO = threeRolls(2, 6)+2;
                baseFYS = threeRolls(2, 6)+1;
                baseMST = threeRolls(2, 6)+10;
                psiSkills = new List<skill>();
                psiMutationer(dice.roll(4) + 1);
            }
            if (klass == 3)
            {
                KLASS = "Robot";
                baseSTY = threeRolls(1, 6)+19;
                baseINT = threeRolls(1, 6)+5;
                basePER = threeRolls(1, 6)+5;
                baseSMI = threeRolls(1, 6)+7;
                baseSTO = threeRolls(1, 6)+12;
                baseFYS = threeRolls(1, 6)+13;
                baseMST = threeRolls(3, 6);
                psiSkills = new List<skill>();
                robotik(dice.roll(4) + 1);
            }
            robAlder = dice.rolls(2,20);
            alder = robAlder;
        }

        private void robotik(int numbr)
        {
            int robInst = 0;
            while (robInst < numbr)
            {
                string newRob;
                newRob = tabeller.getRobot(this);
                while (modifiers.Any(n => n.name.Contains(newRob))&&newRob!="Extrastyrka")
                {
                    newRob = tabeller.getRobot(this);
                }
                if (newRob == "Extrastyrka" && modifiers.Any(n => n.name.Contains(newRob)))
                {
                    modifiers.First(r => r.name.Equals(newRob)).addLVL();
                    robInst++;
                }
                else
                {
                    modifiers.Add(new modifier(newRob,"ROB",this));
                    robInst++;
                }

            }

        }

        private void psiMutationer(int numbr)
        {
            int psiMut = 0;
            int mutSet = 0;
            psiSkills.Add(new skill("Motstå PSI", MST, 2));
            psiSkills.Add(new skill("Aktivt PSI-motstånd", MST+PER));
            psiSkills.Add(new skill("Dölja PSI", MST,2));
            psiSkills.Add(new skill("Känna PSI", MST));
            psiSkills.Add(new skill("Empati", MST));
            modifiers.Add(new modifier("Empati","PSI",this));
            while (psiMut < numbr)
            {
                string newPsi;
                if (mutSet == 0)
                {
                    int _roll = dice.roll(100);
                    mutSet++;
                    if (_roll > 15)
                        mutSet++;
                    if (_roll > 35)
                        mutSet++;
                    if (_roll > 40)
                        mutSet++;
                    if (_roll > 50)
                        mutSet++;
                    if (_roll > 65)
                        mutSet++;
                    if (_roll > 80)
                    {
                        if (psiMut == 0)
                            mutSet = 2;
                        else
                            mutSet++;
                    }
                }
                newPsi = tabeller.getPsiMut(mutSet, this);
                if (modifiers.Any(n => n.name.Equals(newPsi))||psiSkills.Any(n => n.name.Equals(newPsi)))
                {
                    mutSet = 0;
                }
                else
                {
                    if (newPsi == "Känsloläsning")
                    {
                        psiSkills[4].name = newPsi;
                        modifiers[1].name = newPsi;
                        psiMut++;
                    }
                    else if (newPsi == "Djurkontroll")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "WIZ")
                    {
                        int _roll = dice.roll(10);
                        if (_roll < 3)
                        {
                            newPsi += ": NärstridsWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "1H-Närstridsvapen, Kniv, Obeväpnad strid, 2H-Närstridsvapn och Stridskonst";
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].SBbonus += 10;
                            psiMut++;
                        }
                        if (_roll == 4)
                        {
                            newPsi += ": TeknikWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Cybernetik, Elektronik, Robotik och Teknik";
                            psiMut++;
                        }
                        if (_roll == 5)
                        {
                            newPsi += ": BiologiskWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Drogkunskap, Medicin och Sprängteknik";
                            psiMut++;
                        }
                        if (_roll == 6)
                        {
                            newPsi += ": SocialWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Infiltrera, Socialförmåga och Övertyga";
                            psiMut++;
                        }
                        if (_roll == 7)
                        {
                            newPsi += ": StridsWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Blindskott, Snabbdra, Strid i mörker och Undvika";
                            psiMut++;
                        }
                        if (_roll == 8)
                        {
                            newPsi += ": RörelseWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Rörliga manövrar, Gömma sig, Simma och Undvika";
                            psiMut++;
                        }
                        if (_roll == 9)
                        {
                            newPsi += ": UppmärksamhetWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Första hjälpen, Iakttagelseförmåga, Spåra och Undvika";
                            psiMut++;
                        }
                        if (_roll == 10)
                        {
                            newPsi += ": AnalytiskWiz";
                            modifiers.Add(new modifier(newPsi, "PSI", this));
                            modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "Första hjälpen, Socialförmåga, Taktik och Undvika";
                            psiMut++;
                        }

                    }
                    else if (newPsi == "Extra laddning")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Extra energi")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Resistans")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Drömkrafter")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Frihandling")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Absorbation")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Skuggmedvetande")
                    {
                        int newMST = MST*3/2;
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "MST: " + newMST;
                        psiMut++;
                    }
                    else if (newPsi == "Skuggkrafter")
                    {
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        psiMut++;
                    }
                    else if (newPsi == "Ljusvarelse")
                    {
                        int newMST = MST*3/2;
                        modifiers.Add(new modifier(newPsi, "PSI", this));
                        modifiers[modifiers.IndexOf(modifiers.First(n => n.name.Contains(newPsi)))].desc = "MST: " + newMST;
                        psiMut++;
                    }
                    else
                    {
                        psiSkills.Add(new skill(newPsi, MST));
                        modifiers.Add(new modifier(newPsi,"PSI",this));
                        psiMut++;                        
                    }    
                }
                if (mutSet == 7)
                    mutSet = 0;
            }
        }

        private void mutationer(int numbr)
        {
            for (int i = 0; i < numbr; i++)
            {
                int mutNr = rollMut();
                mutationerInt[mutNr]++;
                if (mutationerInt[mutNr] == 1)
                {
                    modifiers.Add(new modifier(mutationerString[mutNr], "MUT", this));                    
                }
                else
                {
                    modifiers.First(m => m.name.Equals(mutationerString[mutNr])).addLVL();
                }
            }
        }

        private int rollMut()
        {
            int result = -1;
            int rolling = dice.roll(100);
            if (rolling < 4)
                result = 0;
            if (rolling > 3 && rolling < 7)
                result = 1;
            if (rolling > 6 && rolling < 10)
                result = 2;
            if (rolling > 9 && rolling < 14)
                result = 3;
            if (rolling > 13 && rolling < 17)
                result = 4;
            if (rolling > 16 && rolling < 20)
                result = 5;
            if (rolling > 19 && rolling < 24)
                result = 6;
            if (rolling > 23 && rolling < 27)
                result = 7;
            if (rolling > 26 && rolling < 30)
                result = 7+dice.roll(4);
            if (rolling > 29 && rolling < 33)
                result = 12;
            if (rolling > 32 && rolling < 37)
                result = 13;
            if (rolling > 36 && rolling < 41)
                result = 14;
            if (rolling > 40 && rolling < 45)
                result = 15;
            if (rolling > 44 && rolling < 49)
                result = 16;
            if (rolling > 48 && rolling < 52)
                result = 17;
            if (rolling > 51 && rolling < 56)
                result = 18;
            if (rolling > 55 && rolling < 59)
                result = 19;
            if (rolling > 58 && rolling < 63)
                result = 20;
            if (rolling > 62 && rolling < 67)
                result = 21;
            if (rolling > 66 && rolling < 70)
                result = 22;
            if (rolling > 69 && rolling < 73)
                result = 23;
            if (rolling > 72 && rolling < 76)
                result = 24;
            if (rolling > 75 && rolling < 80)
                result = 25;
            if (rolling > 79 && rolling < 84)
                result = 26;
            if (rolling > 83 && rolling < 87)
                result = 27;
            if (rolling > 86 && rolling < 90)
                result = 28;
            if (rolling > 89 && rolling < 94)
            {
                int nrmRoll = dice.rolls(3, 6);
                if (nrmRoll > 8 && nrmRoll < 13)
                    result = 29;
                if (nrmRoll == 18)
                    result=30;
                if (nrmRoll > 3 && nrmRoll < 6)
                    result = 31;
                if (nrmRoll > 5 && nrmRoll < 9)
                    result = 32;
                if (nrmRoll > 15 && nrmRoll < 18)
                    result = 33;
                if (nrmRoll > 12 && nrmRoll < 16)
                    result = 34;
                if (nrmRoll == 3)
                    result = 35;
            }
            if (rolling > 93 && rolling < 96)
                result = 36;
            if (rolling > 95 && rolling < 98)
                result = 37;
            if (rolling > 97 && rolling < 100)
                result = 38;
            if (rolling == 100)
                result = 39;
            return result;
        }

        public void makeSkills(int select)
        {
            skills = new List<skill>();
            skills.Add(new skill("Cybernetik", INT));
            skills.Add(new skill("Datorkunskap", INT));
            skills.Add(new skill("Drogkunskap", INT));
            skills.Add(new skill("Elektronik", INT));
            skills.Add(new skill("Elektronhjärnehantering", MST+INT));
            skills.Add(new skill("Fingerfärdighet", SMI+PER));
            skills.Add(new skill("Fixare", INT + PER));
            skills.Add(new skill("Flygfordon", SMI));
            skills.Add(new skill("Förfalskning", INT + PER));
            skills.Add(new skill("Första hjälpen", INT + PER));
            skills.Add(new skill("Gömma sig", SMI + PER));
            skills.Add(new skill("Iakttagelseförmåga", INT + MST));
            skills.Add(new skill("Infiltrera", INT + PER));
            skills.Add(new skill("Markfordon", INT + SMI));
            skills.Add(new skill("Medicin", INT));
            skills.Add(new skill("Robotik", INT));
            skills.Add(new skill("Rörliga manövrar", SMI + STY));
            skills.Add(new skill("Simma", SMI + STY));
            skills.Add(new skill("Socialförmåga", INT + PER));
            skills.Add(new skill("Första språk", INT + 80));
            skills.Add(new skill("Andra språk", INT + 60+dice.roll(20)));
            skills.Add(new skill("Första extra språk", INT));
            skills.Add(new skill("Andra extra språk", INT));
            skills.Add(new skill("Sprängteknik", INT + SMI));
            skills.Add(new skill("Spåra", INT + MST));
            skills.Add(new skill("Säkerhetsrutiner", INT));
            skills.Add(new skill("Teknik", INT));
            skills.Add(new skill("Värdera", INT));
            skills.Add(new skill("Överlevnad", INT + MST));
            skills.Add(new skill("Övertyga", INT + PER));

            combatSkills = new List<skill>();
            combatSkills.Add(new skill("Automatvapen", SMI));
            combatSkills.Add(new skill("Blindskott", SMI));
            combatSkills.Add(new skill("1H-Närstridsvapen", SMI+SMI));
            combatSkills.Add(new skill("Gevär", SMI));
            combatSkills.Add(new skill("Kastvapen", SMI+SMI));
            combatSkills.Add(new skill("Kniv", SMI+SMI));
            combatSkills.Add(new skill("Obeväpnad strid", SMI+SMI));
            combatSkills.Add(new skill("Pistol", SMI));
            combatSkills.Add(new skill("Snabbdra", SMI));
            combatSkills.Add(new skill("Strid i mörker", SMI));
            combatSkills.Add(new skill("Taktik", INT+MST));
            combatSkills.Add(new skill("2H-Närstridsvapen", SMI+SMI));
            if(MST>SMI)
                combatSkills.Add(new skill("Undvika", MST,2));
            else
                combatSkills.Add(new skill("Undvika", SMI,2));
            combatSkills.Add(new skill("Vapensystem", SMI+INT));

            strKst = new stridskonst(select, SMI+SMI, this);

            if (KLASS == "PSI-mutant")
            {
                foreach (modifier element in modifiers)
                {
                    if (element.name.Contains("WIZ"))
                    {
                        for (int i = 0; i < skills.Count; i++)
                        {
                            if (element.desc.Contains(skills[i].name))
                            {
                                skills[i].gcl += 10;
                                skills[i].b_gcl += 10;
                            }
                        }
                        for (int i = 0; i < combatSkills.Count; i++)
                        {
                            if (element.desc.Contains(combatSkills[i].name))
                            {
                                combatSkills[i].gcl += 10;
                                combatSkills[i].b_gcl += 10;
                            }
                        }
                        if (element.desc.Contains("Stridskonst"))
                        {
                            strKst.gcl += 10;
                            strKst.b_gcl += 10;
                        }
                    }
                    if (element.name.Contains("Binarmancy"))
                    {
                        skills[1].gcl += MST;
                        skills[1].b_gcl += MST;
                    }
                    if (element.name.Contains("Technomancy"))
                    {
                        skills[0].gcl += MST;
                        skills[0].b_gcl += MST;
                        skills[3].gcl += MST;
                        skills[3].b_gcl += MST;
                        skills[15].gcl += MST;
                        skills[15].b_gcl += MST;
                        skills[26].gcl += MST;
                        skills[26].b_gcl += MST;
                    }
                }
            }
            else
            {
                if (KLASS != "Robot")
                {
                    psiSkills.Add(new skill("Motstå PSI", MST,5));
                    psiSkills.Add(new skill("Aktivt PSI-motstånd", MST+PER, 2));                         
                }
            }
        }

        public int getEP()
        {
            int ep = 20;
            if (INT > 1)
                ep += 10;
            if (INT > 3)
                ep += 10;
            if (INT > 5)
                ep += 10;
            if (INT > 8)
                ep += 10;
            if (INT > 13)
                ep += 10;
            if (INT > 15)
                ep += 10;
            if (INT > 17)
                ep += 10;
            if (INT > 18)
                ep += 10;
            ep += INT;
            if (KLASS == "Människa")
                ep += (INT + alder);
            return (ep*EPmod)/5+(INT+alder);

        }

        public int getPsiEP()
        {
            int ep = 20;
            if (MST > 1)
                ep += 10;
            if (MST > 3)
                ep += 10;
            if (MST > 5)
                ep += 10;
            if (MST > 8)
                ep += 10;
            if (MST > 13)
                ep += 10;
            if (MST > 15)
                ep += 10;
            if (MST > 17)
                ep += 10;
            if (MST > 18)
                ep += 10;
            return (ep*EPmod)/5;
        }

        public int getYrkeEP()
        {
            int ep = getEP();
            if (KLASS == "Människa")
                ep -= (INT + alder);
            return ep - (INT + alder);
        }


        public void setAlder(int a)
        {
            if (KLASS == "Robot")
            {
                a = robAlder;
            }
            if (tYrke.indexKey == 12 && a < 35)
                a = 35;
            if (KLASS != "Robot")
            {
                if (a < 8)
                    a = 8;
                if (a > 90)
                    a = 90;
                if (a == 8)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.3) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.3) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*0.7) - baseSMI;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 2;
                }
                if (a == 9)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.4) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.4) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*0.7) - baseINT;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 2;
                }
                if (a == 10)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.4) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.4) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*0.8) - baseSMI;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 3;
                }
                if (a == 11)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.4) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.4) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*0.8) - baseSMI;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 3;
                }
                if (a > 11 && a < 14)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.5) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.5) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*0.9) - baseSMI;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 4;
                }
                if (a > 13 && a < 16)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.7) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.7) - baseSTO;
                    modifiers[0].FYS = Convert.ToInt32(baseFYS*1.1) - baseFYS;
                    modifiers[0].SMI = 0;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 4;
                }
                if (a > 15 && a < 18)
                {
                    modifiers[0].STY = Convert.ToInt32(baseSTY*0.9) - baseSTY;
                    modifiers[0].STO = Convert.ToInt32(baseSTO*0.9) - baseSTO;
                    modifiers[0].FYS = 0;
                    modifiers[0].SMI = Convert.ToInt32(baseSMI*1.1) - baseSMI;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 5;
                }
                if (a > 17 && a < 20)
                {
                    modifiers[0].STY = 0;
                    modifiers[0].STO = 0;
                    modifiers[0].FYS = 0;
                    modifiers[0].SMI = 1;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 5;
                }
                if (a > 19 && a < 46)
                {
                    modifiers[0].STY = 0;
                    modifiers[0].STO = 0;
                    modifiers[0].FYS = 0;
                    modifiers[0].SMI = 0;
                    modifiers[0].INT = 0;
                    modifiers[0].MST = 0;
                    modifiers[0].PER = 0;
                    EPmod = 5;
                }
                if (a > 45 && a < 61)
                {
                    modifiers[0].STY = -2;
                    modifiers[0].STO = 0;
                    modifiers[0].FYS = -1;
                    modifiers[0].SMI = -2;
                    modifiers[0].INT = 1;
                    modifiers[0].MST = 2;
                    modifiers[0].PER = 1;
                    EPmod = 5;
                }
                if (a > 60)
                {
                    modifiers[0].STY = -5;
                    modifiers[0].STO = 0;
                    modifiers[0].FYS = -3;
                    modifiers[0].SMI = -4;
                    modifiers[0].INT = 1;
                    modifiers[0].MST = 4;
                    modifiers[0].PER = 1;
                    EPmod = 5;
                }
            }
            alder = a;
        }

        public void setYrke(int y)
        {
            tYrke = new yrke(y);
            if (KLASS == "Människa")
            {
                while(modifiers.Count(n => n.type.Equals("CYB"))>0)
                {
                    modifiers.Remove(modifiers.First(n => n.type.Equals("CYB")));
                }

                if (tYrke.getCybernetik() != null)
                {
                    int rolls = 1;
                    if (tYrke.indexKey == 12)
                    {
                        if (PER > 8)
                            rolls++;
                        if (PER > 11)
                            rolls++;
                        if (PER > 18)
                            rolls++;
                    }
                    else
                    {
                        if (PER > 5)
                            rolls++;
                        if (PER > 8)
                            rolls++;
                        if (PER > 15)
                            rolls++;
                    }
                    for (int i = 1; i <= rolls; i++)
                    {
                        string newCyber =tYrke.getCybernetik();
                        while (modifiers.Any(n => n.name.Contains(newCyber)))
                        {
                            newCyber = tYrke.getCybernetik();
                        }
                        modifiers.Add(new modifier(newCyber, "CYB", this));
                    }
               
                }

            }
        }
    }
}
