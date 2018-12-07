using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal.Forms
{
    public partial class NiveauTache : Form
    {
        public NiveauTache()
        {
            InitializeComponent();
        }

        private void NiveauTache_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.Tache'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tacheTableAdapter.Fill(this.bDDFinalDataSetBien.Tache);

        }

        private void DetailProj_Click(object sender, EventArgs e)
        {
            new NiveauExi().Show();
            //this.Close();
        }

        private void AjoutProj_Click(object sender, EventArgs e)
        {
            new AddTache().Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJalon_Click(object sender, EventArgs e)
        {
            new NiveauJalon().Show();
        }

        private void ModifProj_Click(object sender, EventArgs e)
        {
            new ModifTache().Show();
        }
    }
}
