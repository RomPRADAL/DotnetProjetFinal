using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetFinal.BDDFinalDataSetBienTableAdapters;

namespace ProjetFinal.Forms
{
    public partial class AddProjet : Form
    {
        public AddProjet()
        {
            InitializeComponent();
            //int IdInsert = (int)new ProjetTableAdapter().NbrProj()+1;
            textBoxId.Text+= new ProjetTableAdapter().NbrProj()+1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //DataTable dataTable;
            //DataRow workRow = dataTable.NewRow(); //= ProjetFinal.BDDFinalDataSet
            //BDDFinalDataSetBien.ProjetRow();
            //            BDDFinalDataSetBien.ProjetRow projetRow =saret            
            //                BDDFinalDataSetBien.ProjetDataTable;
            //BDDFinalDataSetBien.ProjetRow ProjetRow = BDDFinalDataSetBien.ProjetDataTable.FindByid(1);
            int Maxid = (int)new ProjetTableAdapter().NbrProj();
            //new ProjetTableAdapter().InsertQuery(Maxid+1,textBoxNom.Text,textBoxRespon.Text);
            new ProjetTableAdapter().InsertQuery(Maxid + 1, textBoxNom.Text, cbResp.Text);
        }

        private void AddProjet_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.User'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userTableAdapter.Fill(this.bDDFinalDataSetBien.User);

        }
    }
}
