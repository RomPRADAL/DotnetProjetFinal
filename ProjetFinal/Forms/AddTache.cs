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
    public partial class AddTache : Form
    {
        public AddTache()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Maxid = (int)new TacheTableAdapter().NbrTache();
            //new ProjetTableAdapter().InsertQuery(Maxid + 1, textBoxNom.Text, textBoxRespon.Text);
            //new TacheTableAdapter().InsertQuery(Maxid + 1, textBoxNom.Text, textBoxDescri.Text, textBoxResp.Text, Maxid, dateTimeDeb.ToString(), dateTimeReel.ToString(), Maxid, checkBoxTerm.ToString());
            new TacheTableAdapter().InsertQuery(Maxid + 1, textBoxNom.Text, textBoxDescri.Text, textBoxResp.Text, Maxid, null, null, 0, checkBoxTerm.ToString());
            this.Close();
        }
    }
}
