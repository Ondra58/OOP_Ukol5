using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected int hodinovaMzda;
        public int HodinovaMzda 
        { 
            get => hodinovaMzda; 
        }
        protected int odpracHodiny = 0;
        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
        }
        public virtual int PocetDni()
        {
            return (int)(DateTime.Now - datumNastupu).TotalDays;
        }

        public virtual void OdpracujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }

        public virtual int VypocitejMzdu()
        {
            return hodinovaMzda * odpracHodiny;
        }
        public virtual string Vypis()
        {
            return "Jméno: " + jmeno + "\nPřijmení: " + prijmeni + "\nDatum nástupu: " + datumNastupu + "\nHodinová mzda: " + HodinovaMzda + "\nOdpracováno hodin: " + odpracHodiny + "\nMzda: " + VypocitejMzdu();
        }
    }
}
