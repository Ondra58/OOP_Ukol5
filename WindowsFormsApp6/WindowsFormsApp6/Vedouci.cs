using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class Vedouci : Zamestnanec
    {
        private int priplatekZaVedeni;
        private string titul;
        public Vedouci(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, int priplatekZaVedeni, string titul) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
        }
        public override int VypocitejMzdu()
        {
            return base.VypocitejMzdu() + (odpracHodiny * priplatekZaVedeni);
        }
        public override string Vypis()
        {
            return "Titul: " + titul + "\nJméno: " + jmeno + "\nPřijmení: " + prijmeni + "\nDatum nástupu: " + datumNastupu + "\nHodinová mzda: " + HodinovaMzda + "\nOdpracováno hodin: " + odpracHodiny + "\nMzda: " + VypocitejMzdu();
        }
    }
}
