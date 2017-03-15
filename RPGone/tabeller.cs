using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGone
{
    public class tabeller
    {
        private dice dice = new dice();

        public string getPsiMut(int nmr, character sender)
        {
            if (nmr == 1)
            {
                int _r = dice.roll(100);
                if (_r < 11)
                    return "Dechiffrering";
                if (_r > 10 && _r < 21)
                    return "Mental Identifikation";
                if (_r > 20 && _r < 41)
                    return "Psykometri";
                if (_r > 40 && _r < 71)
                    return "Intuition";
                if (_r > 70 && _r < 81)
                    return "Instinktivt försvar";
                if (_r > 80 && _r < 91)
                {
                    if (sender.psiSkills.Any(n => n.name.Contains("Tur")))
                    {
                        _r = dice.roll(100);
                        if (_r < 61)
                            return "Olycka";
                        if (_r > 60)
                            return "Förlorat fokus";
                    }
                    return "Tur"; 
                }
                if (_r > 90)
                    return "Paranoia";
            }
            if (nmr == 2)
            {
                int _r = dice.roll(100);
                if (_r < 16)
                    return "Känsloläsning";
                if (_r > 15 && _r < 26)
                    return "Distraktion";
                if (_r > 25 && _r < 36)
                    return "Mental sträck";
                if (_r > 35 && _r < 41)
                    return "Mental stöt";
                if (_r > 40 && _r < 46)
                    return "Mental osynlighet";
                if (_r > 45 && _r < 51)
                    return "Mentalt anfall";
                if (_r > 50 && _r < 56)
                    return "Stopp";
                if (_r > 55 && _r < 76)
                {
                    _r = dice.roll(100);
                    if (sender.psiSkills.Any(n => n.name.Contains("Telepati")))
                    {
                        if (_r < 21)
                        {
                            if (sender.psiSkills.Any(n => n.name.Contains("Stjäla kunskap")))
                                return "Själavandring";
                            return "Stjäla kunskap";   
                        }

                        if (_r > 20 && _r < 41)
                        {
                            if (sender.psiSkills.Any(n => n.name.Contains("Dela kunskap")))
                                return "Delge";
                            return "Dela kunskap";
                        }
                        if (_r > 40)
                        {
                            if (sender.psiSkills.Any(n => n.name.Contains("Mental överbelastning")))
                            {
                                _r = dice.roll(100);
                                if (_r < 76)
                                    return "Mental kortslutning";
                                if (_r > 75)
                                    return "Besätta";
                            }
                            return "Mental överbelastning";
                        }          
                    }
                    return "Telepati";
                }
                if (_r > 75 && _r < 91)
                    return "Känslopåverkan";
                if (_r > 90)
                    return "Mental block";
            }
            if (nmr == 3)
            {
                int _r = dice.roll(100);
                if (_r < 4)
                    return "Värmeskydd";
                if (_r > 3 && _r < 7)
                    return "Fysisk förstärkning";
                if (_r > 6 && _r < 13)
                    return "Kraftfält";
                if (_r > 12 && _r < 16)
                    return "Magnetfält";
                if (_r > 15 && _r < 19)
                    return "Energifält";
                if (_r > 18 && _r < 23)
                    return "Kraftfältsavläsning";
                if (_r > 22 && _r < 28)
                    return "Magnetesi";
                if (_r > 27 && _r < 31)
                    return "Snabb läkning";
                if (_r > 30 && _r < 35)
                    return "Förbränning";
                if (_r > 34 && _r < 38)
                {
                    if (sender.psiSkills.Any(n => n.name.Contains("Kryogenesi")))
                        return "Kryodvala";
                    return "Kryogenesi";
                }
                if (_r > 37 && _r < 42)
                    return "Elementmotstånd";
                if (_r > 41 && _r < 47)
                    return "Energikropp";
                if (_r > 46 && _r < 51)
                    return "Osynlighet";
                if (_r > 50 && _r < 54)
                    return "Sonar";
                if (_r > 53 && _r < 58)
                    return "Energiurladdning";
                if (_r > 57 && _r < 61)
                    return "Eldskydd";
                if (_r > 60 && _r < 66)
                    return "Levitation";
                if (_r > 65 && _r < 76)
                    return "Technomancy";
                if (_r > 75 && _r < 86)
                {
                    if (sender.psiSkills.Any(n => n.name.Contains("Technovision")))
                    {
                        if(!sender.psiSkills.Any(n => n.name.Contains("Binarteori")))
                            if (sender.psiSkills.Any(n => n.name.Contains("Binarmancy")) ||
                                sender.psiSkills.Any(n => n.name.Contains("Technoteori")))
                                return "Binarteori";
                        return "Technoteori";
                    }
                    return "Technovision";
                }
                if (_r > 85 && _r < 91)
                    return "Energikontroll";
                if (_r > 90)
                    return "Binarmancy";
            }
            if (nmr == 4)
            {
                int _r = dice.roll(100);
                if (_r < 11)
                    return "Djurkontroll";
                if (_r > 10 && _r < 21)
                    return "Fysisk förstärkning";
                if (_r > 20 && _r < 26)
                    return "Koncentration";
                if (_r > 25 && _r < 31)
                    return "Nervblockering";
                if (_r > 30 && _r < 41)
                    return "Sinnesskärpning";
                if (_r > 40 && _r < 51)
                    return "Stopp";
                if (_r > 50 && _r < 61)
                    return "Osynlighet";
                if (_r > 60 && _r < 71)
                    return "Teleportering";
                if (_r > 70 && _r < 81)
                    return "Snabbhet";
                if (_r > 80 && _r < 91)
                    return "Läkning";
                if (_r > 90)
                    return "Mental block";
            }
            if (nmr == 5)
            {
                int _r = dice.roll(100);
                if (_r < 11)
                    return "Distraktion";
                if (_r > 10 && _r < 21)
                    return "Dödstanke";
                if (_r > 20 && _r < 26)
                    return "Tankestöt";
                if (_r > 25 && _r < 36)
                    return "Tryckanfall";
                if (_r > 35 && _r < 41)
                    return "Illusion";
                if (_r > 40 && _r < 51)
                    return "Mental skräck";
                if (_r > 50 && _r < 56)
                    return "Mental block";
                if (_r > 55 && _r < 66)
                    return "Mentalt Anfall";
                if (_r > 65 && _r < 71)
                    return "Stopp";
                if (_r > 70 && _r < 81)
                    return "Mental osynlighet";
                if (_r > 80 && _r < 91)
                    return "Slöhet";
                if (_r > 90)
                    return "Skräcknova";
            }
            if (nmr == 6)
            {
                int _r = dice.roll(100);
                if (_r < 76)
                {
                    if (sender.psiSkills.Any(n => n.name.Contains("Telekinesi")))
                    {
                        _r = dice.roll(100);
                        if (_r < 21)
                        {
                            if (sender.psiSkills.Any(n => n.name.Contains("Micro-Telekinesi")))
                            {
                                _r = dice.roll(100);
                                if (_r < 31)
                                    return "Telekinesi hugg";
                                if (_r > 30 && _r < 61)
                                    return "Telekinesi grepp";
                                if (_r > 60 && _r < 91)
                                    return "Cybertelekinesi";
                                if (_r > 90)
                                    return "Biotelekinesi";
                            }
                            return "Micro-Telekinesi";
                        }
                        if (_r > 20 && _r < 31)
                            return "Telekinesi sköld";
                        if (_r > 30 && _r < 41)
                            return "Telekinesi fokus";
                        if (_r > 40 && _r < 51)
                            return "Telekinesi koncentration";
                        if (_r > 50 && _r < 61)
                            return "Telekinesi explosion";
                        if (_r > 60 && _r < 81)
                            return "Telekinesi parad";
                        if (_r > 80 && _r < 91)
                            return "Telekinesi slag";
                        if (_r > 90)
                            return "Macro-Telekinesi";
                        return "Telekinesi";
                    }
                } 
                if (_r > 75 && _r < 91)
                    return "Levitation";
                if (_r > 90)
                    return "Kraftvåg";
            }
            if (nmr == 7)
            {
                int _r = dice.roll(100);
                if (_r < 9)
                    return "Masspåverkan";
                if (_r > 8 && _r < 15)
                    return "Distansberöring";
                if (_r > 14 && _r < 19)
                    return "Fördröjd verkan";
                if (_r > 18 && _r < 23)
                    return "Protophason aktivitet";
                if (_r > 22 && _r < 28)
                    return "Kontrollera sinne";
                if (_r > 27 && _r < 33)
                    return "Telekontroll";
                if (_r > 32 && _r < 38)
                    return "Kraftblock";
                if (_r > 37 && _r < 43)
                {

                    return "Prekognition";
                }
                if (_r > 42 && _r < 50)
                    return "WIZ";
                if (_r > 49 && _r < 54)
                    return "Asimov";
                if (_r > 53 && _r < 62)
                    return "Extra laddning";
                if (_r > 61 && _r < 68)
                    return "Extra energi";
                if (_r > 67 && _r < 72)
                    return "Resistans";
                if (_r > 71 && _r < 75)
                    return "Annat medium";
                if (_r > 74 && _r < 78)
                    return "Drömkrafter";
                if (_r > 77 && _r < 85)
                    return "Mentalsonar";
                if (_r > 84 && _r < 89)
                    return "Frihandling";
                if (_r > 88 && _r < 93)
                    return "Absorbation";
                if (_r > 92 && _r < 95)
                    return "Skuggmedvetande";
                if (_r > 94 && _r < 97)
                    return "Skuggkrafter";
                if (_r > 96 && _r < 99)
                    return "Ljusvarelse";
                if (_r > 98)
                    return "Unik kraft";
            }

            return "Motstå PSI";
        }

        public string getRobot(character sender)
        {
            int _r = dice.roll(20);
            if (_r == 1)
                return "Fotoreceptor";
            if (_r == 2)
                return "Lingoterminal";
            if (_r == 3)
                return "Sonar";
            if (_r == 4)
                return "Bepansring";
            if (_r == 5 || _r ==6)
                return "Extrastyrka";
            if (_r == 7)
                return "Stålskalle";
            if (_r == 8)
                return "Elektroder";
            if (_r == 9)
                return "IR-öga";
            if (_r == 10)
                return "Radioutrustning";
            if (_r == 11)
                return "Lasersikte";
            if (_r == 12)
                return "Röntgenöga";
            if (_r == 13)
                return "Sekundärminne";
            if (_r == 14)
                return "Kraftsensor";
            if (_r == 15)
                return "Audioaugmentor";
            if (_r == 16)
                return "Frätskydd";
            if (_r == 17)
                return "Lättviktskropp";
            if (_r == 18)
                return "Neurojack";
            if (_r == 19)
                return "Kraftfält";
            if (_r == 20)
                return "Nanoväv";
            return "Ultra lättviktskropp";
        }

    }
}
