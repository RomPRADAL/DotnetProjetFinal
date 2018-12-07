using ProjetFinal.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal.Interfaces
{
    interface ProjetInterface
    {
        List<Projet> GetAllProjets();

        bool SaveProjet(Projet p_projet);
    }
}
