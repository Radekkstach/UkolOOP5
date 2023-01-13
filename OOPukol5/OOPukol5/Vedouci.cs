using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol5
{
    internal class Vedouci : Zamestnanec
    {
        private int priplatekZaVedeni;
        private string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda,int priplatekZaVedeni,string titul) : base (jmeno,prijmeni,datumNastupu,hodinovaMzda)
        { 
            this.priplatekZaVedeni= priplatekZaVedeni;
            this.titul = titul;
        }

        public override int VypocitaMzdu()
        {
            int mzda;
            mzda = hodinovaMzda * odpracHodiny;
            mzda = mzda + priplatekZaVedeni;
            return mzda;
        }

        public override string Vypis()
        {
            return titul+jmeno + " " + prijmeni + " s hodinovou mzdou " + hodinovaMzda + " a " + odpracHodiny + " odpracovanych hodin\nMa mzdu " + VypocitaMzdu() + "\nPracuje " + Math.Round(PocetDni().TotalDays, 0) + " dni";
        }
    }
}
