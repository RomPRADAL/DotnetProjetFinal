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
    public partial class NiveauExi : Form
    {
        public NiveauExi()
        {
            InitializeComponent();
        }

        private void NiveauExi_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.Exigence'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.exigenceTableAdapter.Fill(this.bDDFinalDataSetBien.Exigence);
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.Tache'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tacheTableAdapter.Fill(this.bDDFinalDataSetBien.Tache);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
