using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetFinal.BDDFinalDataSet1TableAdapters;

namespace ProjetFinal.Objets
{
    class Exigence
    {
        public int Id { get; set; }
        public int Projet { get; set; }
        public string Label { get; set; }
        public int Type { get; set; }
        public string Details { get; set; }
        public int Livrable { get; set; } //Peut être à virer

        public override string ToString()
        {
            return "Id = "+this.Id+", Label "+this.Label;
        }
    }

}
