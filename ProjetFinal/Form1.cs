using ProjetFinal.BDDFinalDataSet1TableAdapters;
using ProjetFinal.BDDFinalDataSetBienTableAdapters;
using ProjetFinal.Forms;
using ProjetFinal.Services;
using ProjetFinal.Interfaces;
using ProjetFinal.Objets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetTableAdapter = ProjetFinal.BDDFinalDataSetBienTableAdapters.ProjetTableAdapter;

namespace ProjetFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //= new AddProjet();
            new AddProjet().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSetBien.Projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.projetTableAdapter1.Fill(this.bDDFinalDataSetBien.Projet);
            // TODO: cette ligne de code charge les données dans la table 'bDDFinalDataSet1.Projet'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.projetTableAdapter.Fill(this.bDDFinalDataSet1.Projet);
            
            //Refresh la gridview toutes les 5secondes pour afficher les changements
            Timer timer = new Timer();
            timer.Interval = (5 * 1000); // 5 secondes
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void DetailProj_Click(object sender, EventArgs e)
        {
            //BDDFinalDataSetBien.ProjetRow projetRow=
            //BDDFinalDataSetBien.ProjetDataTable.FindByCustomerID("ALFKI");
            new NiveauTache().Show();
            //this.projetTableAdapter.Insert(5,"lololo","azeazeaz");
        }

        private void ModifProj_Click(object sender, EventArgs e)
        {
            //this.projetTableAdapter.Update(this.bDDFinalDataSet1);
            //this.projetTableAdapter.FillByNom();ù
            //ExigenceTableAdapter.Fill();
            //ProjetTableAdapter.Fill(this.bDDFinalDataSet1.Projet);
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            string vRet = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            new ModifProj(vRet).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lors d'un click
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;

            string vRet = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();

            //new ModifProj(vRet).Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void btnForceRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}