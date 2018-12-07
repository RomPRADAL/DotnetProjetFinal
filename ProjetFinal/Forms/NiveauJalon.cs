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
    public partial class NiveauJalon : Form
    {
        public NiveauJalon()
        {
            InitializeComponent();
        }

        private void NiveauJalon_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.Livrable'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.livrableTableAdapter.Fill(this.bDDFinalDataSetBien.Livrable);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjoutProj_Click(object sender, EventArgs e)
        {
            new AddJalon().Show();
        }

        private void ModifProj_Click(object sender, EventArgs e)
        {
            new ModifJalon().Show();
        }
    }
}
