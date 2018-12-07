using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal.BDDFinalDataSet1TableAdapters;

namespace ProjetFinal.Objets
{
    public class Projet
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Responsable { get; set; }

        public override string ToString()
        {
            return "Id = " + this.Id + ", Nom " + this.Nom;
        }
    }
}
