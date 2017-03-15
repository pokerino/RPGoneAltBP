using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGone
{
    public class stridskonst:skill
    {
        public IList<maneuvers> maneuverses;
        public stridskonst(int s, int g, character sender)
        {
            if (s == 0)
            {
                name = "An Chi´i";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Distrahera", "none"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Föreutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Rullande attack", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kniv]", this));
                maneuverses.Add(new maneuvers("Vidvinkelsyn", "none"));
            }
            if (s == 1)
            {
                name = "Bagua";
                b_gcl = g;
                gcl = b_gcl;
                cost = 6;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Bedövningsslag", this));
                maneuverses.Add(new maneuvers("Blind strid", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Föreutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Föreutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Vidvinkelsyn", "none"));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 2)
            {
                name = "Bando";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Armbåge", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Slag]", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Skallning", this));
            }
            if (s == 3)
            {
                name = "Boxning";
                b_gcl = g;
                gcl = b_gcl;
                cost = 2;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Initativbonus", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 4)
            {
                name = "Capoeira";
                b_gcl = g;
                gcl = b_gcl;
                cost = 5;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Distrahera", "none"));
                maneuverses.Add(new maneuvers("Dubbelspark", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Rullande attack", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 5)
            {
                name = "Chin Na";
                b_gcl = g;
                gcl = b_gcl;
                cost = 5;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Bedövningsslag", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Brytning]", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Kast]", this));
                maneuverses.Add(new maneuvers("Dödande anfall", "none"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
            }
            if (s == 6)
            {
                name = "Escrima";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Armbåge", this));
                maneuverses.Add(new maneuvers("Blind strid", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Knäspark", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Batong/stav]", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kniv]", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 7)
            {
                name = "Hapkido";
                b_gcl = g;
                gcl = b_gcl;
                cost = 2;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
            }
            if (s == 8)
            {
                name = "Jeet Kune Do";
                b_gcl = g;
                gcl = b_gcl;
                cost = 8;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Anfall bakifrån", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Bakåtspark",this));
                maneuverses.Add(new maneuvers("Bedövningsslag", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Slag]", this));
                maneuverses.Add(new maneuvers("Distrahera", "none"));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 9)
            {
                name = "Judo";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Kast]", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Högt kast", this));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Rustad strid", this));
            }
            if (s == 10)
            {
                name = "Jujutsu";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Defensive teknik [Lås/neddr.]", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Högt kast", this));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
            }
            if (s == 11)
            {
                name = "Shotokan Karate";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 12)
            {
                name = "Goju Ryu Karate";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Armbåge", this));
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Defensiv teknik [Slag]", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Knäspark", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
            }
            if (s == 13)
            {
                name = "Ishin Ryu Karate";
                b_gcl = g;
                gcl = b_gcl;
                cost = 6;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Högt kast", this));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Paradvapen]", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Stavar]", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 14)
            {
                name = "Ryukyu Shourin Ryu";
                b_gcl = g;
                gcl = b_gcl;
                cost = 6;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Fint",this));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Paradvapen]", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kedjevapen]", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Stavar]", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 15)
            {
                name = "Kendo";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Defensive teknik [Slag]", this));
                maneuverses.Add(new maneuvers("Dödande anfall", "none"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Kiai", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Svärd]", this));
            }
            if (s == 16)
            {
                name = "Kickboxning";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
            }
            if (s == 17)
            {
                name = "Pigua";
                b_gcl = g;
                gcl = b_gcl;
                cost = 5;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Distrahera", "none"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Kungshand", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 18)
            {
                name = "Pankration";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Knäspark", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Högt kast", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
            }
            if (s == 19)
            {
                name = "Polisens När.Tek.";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rustad strid", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Batong]", this));
            }
            if (s == 20)
            {
                name = "Rysk kommandostrid";
                b_gcl = g;
                gcl = b_gcl;
                cost = 6;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Anfall bakifrån", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Dödande anfall", "none"));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Rustad strid", this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kniv]", this));
            }
            if (s == 21)
            {
                name = "Sakura Ninjutsu";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Anfall bakifrån", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Distrahera", "none"));
                maneuverses.Add(new maneuvers("Dödande anfall", "none"));
                maneuverses.Add(new maneuvers("Falltenik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Vapen teknik [Snara/rep]", this));
            }
            if (s == 22)
            {
                name = "Savate";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Anfall bakifrån", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Bakåttryckspark", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Spark]", this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Spinhälsspark", this));
                maneuverses.Add(new maneuvers("Tryckspark", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kniv]", this));
            }
            if (s == 23)
            {
                name = "SEAL Kommandostrid";
                b_gcl = g;
                gcl = b_gcl;
                cost = 5;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Avväpning", this));
                maneuverses.Add(new maneuvers("Bedövningsslag", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Dödande anfall", "none"));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Rustad strid", this));
                maneuverses.Add(new maneuvers("Vapen teknik [Kniv]", this));
            }
            if (s == 24)
            {
                name = "Sport judo";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Högt kast", this));
                maneuverses.Add(new maneuvers("Initiativbonus","none"));
                maneuverses.Add(new maneuvers("Liggande/knästående strid", "none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
            }
            if (s == 25)
            {
                name = "Muay Thai";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Armbåge", this));
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Knäspark", this));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Låsning/Neddragning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Skallning",this));
                maneuverses.Add(new maneuvers("Stålsättning", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
            }
            if (s == 26)
            {
                name = "Tae kwon do";
                b_gcl = g;
                gcl = b_gcl;
                cost = 3;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Virvelvindsanfall","none"));
            }
            if (s == 27)
            {
                name = "Tai Chi";
                b_gcl = g;
                gcl = b_gcl;
                cost = 4;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Armbåge", this));
                maneuverses.Add(new maneuvers("Bedövningsslag", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Förutse anfall", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Förutse blotta", "Iakttagelseförmåga"));
                maneuverses.Add(new maneuvers("Initiativbonus", "none"));
                maneuverses.Add(new maneuvers("Krosslag", this));
                maneuverses.Add(new maneuvers("Lågt kast/fällning", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
            }
            if (s == 28)
            {
                name = "Tang soo do";
                b_gcl = g;
                gcl = b_gcl;
                cost = 5;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Dubbelslag",this));
                maneuverses.Add(new maneuvers("Dubbelspark",this));
                maneuverses.Add(new maneuvers("Fint", this));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Obeväpnad parering av vapen", this));
                maneuverses.Add(new maneuvers("Rullande attack", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
            if (s == 29)
            {
                name = "Wushu";
                b_gcl = g;
                gcl = b_gcl;
                cost = 6;
                maneuverses = new List<maneuvers>();
                maneuverses.Add(new maneuvers("Anfall bakifrån", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Bakåtspark", this));
                maneuverses.Add(new maneuvers("Brytning", this));
                maneuverses.Add(new maneuvers("Defensive teknik [Spark]", this));
                maneuverses.Add(new maneuvers("Fallteknik/rullning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Fint",this));
                maneuverses.Add(new maneuvers("Fjärilsspark",this));
                maneuverses.Add(new maneuvers("Hoppspark", this));
                maneuverses.Add(new maneuvers("Initiativbonus","none"));
                maneuverses.Add(new maneuvers("Lågt kast/fällning",this));
                maneuverses.Add(new maneuvers("Normalt slag", this));
                maneuverses.Add(new maneuvers("Normal spark", this));
                maneuverses.Add(new maneuvers("Rundspark", this));
                maneuverses.Add(new maneuvers("Tornadospark",this));
                maneuverses.Add(new maneuvers("Undanmanöver", this));
                maneuverses.Add(new maneuvers("Uppresning", "Rörliga manövrar"));
                maneuverses.Add(new maneuvers("Vapen teknik [Valfritt]", this));
                maneuverses.Add(new maneuvers("Virvelvindsanfall", "none"));
            }
        }

        public IList<maneuvers> GetManeuverses()
        {
            return maneuverses;
        }
    }
}
