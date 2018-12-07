using ProjetFinal.BDDFinalDataSetBienTableAdapters;
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
    public partial class ModifProj : Form
    {
        public ModifProj(string pRet)
        {
            InitializeComponent();
            //textBoxId.Text += new ProjetTableAdapter().NbrProj() + 1;
            //numId.Value += pRet;
            textBoxId.Text += pRet;
            textBoxNom.Text += new ProjetTableAdapter().GetData();
            //textBoxRespon.Text += new ProjetTableAdapter().GetData().responsableColumn;
            //textBoxNom.Text += .Tables[0].Rows[0]["ID"].ToString();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            //mettre update
            //new ProjetTableAdapter().UpdateQuery(textBoxId.Text, textBoxNom.Text, textBoxRespon.Text, textBoxId.Text, 0,0,"");
            this.Close();
        }

        private void ModifProj_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.User'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userTableAdapter.Fill(this.bDDFinalDataSetBien.User);

        }
    }
}
