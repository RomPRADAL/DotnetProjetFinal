using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal.BDDFinalDataSet1TableAdapters;

namespace ProjetFinal.Objets
{
    public class Tache
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Responsable { get; set; }
        public int Exigence { get; set; }
        public DateTime DateDeb { get; set; }
        public DateTime DateReel { get; set; }
        public int Charge { get; set; }
        public string Termine { get; set; }

        public override string ToString()
        {
            return "Id = " + this.Id + ", Nom " + this.Nom;
        }
    }
}
