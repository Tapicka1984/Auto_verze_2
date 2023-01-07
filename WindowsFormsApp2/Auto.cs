using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Auto
    {
        private string znacka;
        private int spotreba;
        private double ujetoCelkem;
        private double dobaJizdyCelkem;
        private DateTime rozjezd;
        bool Jede;

        public Auto(string znacka, int spotreba, int ujetoCelkem)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            this.ujetoCelkem = ujetoCelkem;
            dobaJizdyCelkem = 0;
        }

        public double VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjezd()
        {
            Jede = true;
            rozjezd = DateTime.Now;
        }

        public void Zastav(int cislo)
        {
            if(Jede == true)
            {
                TimeSpan Doba_jizdy = DateTime.Now - rozjezd;
                ujetoCelkem += cislo;
                dobaJizdyCelkem += (Doba_jizdy.Seconds);
                Jede = false;
            }
            else
            {

            }
        }

        public double CelkovaSporteba()
        {
            return ((ujetoCelkem*spotreba)/100);
        }

        public override string ToString()
        {
            return ("znacka je:" + znacka + "\n" + "Jede:" + Jede + "\n" + "Auto se rozjelo v:" + rozjezd + "\n" + "Auto ujelo:" + VratUjeteKm() + "km\n" + "spotrebovalo" + CelkovaSporteba() + "L\n" + "Auto jelo" + dobaJizdyCelkem + "sekund\n");
        }

    }
}
