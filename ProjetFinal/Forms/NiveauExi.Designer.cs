namespace ProjetFinal.Forms
{
    partial class NiveauExi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.ModifProj = new System.Windows.Forms.Button();
            this.AjoutProj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exigenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.tacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacheTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.TacheTableAdapter();
            this.exigenceTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.ExigenceTableAdapter();
            this.fKTacheExigenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exigenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTacheExigenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(12, 343);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(219, 37);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // ModifProj
            // 
            this.ModifProj.Location = new System.Drawing.Point(12, 282);
            this.ModifProj.Name = "ModifProj";
            this.ModifProj.Size = new System.Drawing.Size(219, 37);
            this.ModifProj.TabIndex = 11;
            this.ModifProj.Text = "Modifier";
            this.ModifProj.UseVisualStyleBackColor = true;
            // 
            // AjoutProj
            // 
            this.AjoutProj.Location = new System.Drawing.Point(12, 221);
            this.AjoutProj.Name = "AjoutProj";
            this.AjoutProj.Size = new System.Drawing.Size(219, 37);
            this.AjoutProj.TabIndex = 10;
            this.AjoutProj.Text = "Ajout";
            this.AjoutProj.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.projet,
            this.label,
            this.type,
            this.details,
            this.livrable});
            this.dataGridView1.DataSource = this.exigenceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(309, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(944, 420);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // exigenceBindingSource
            // 
            this.exigenceBindingSource.DataMember = "Exigence";
            this.exigenceBindingSource.DataSource = this.bDDFinalDataSetBien;
            // 
            // bDDFinalDataSetBien
            // 
            this.bDDFinalDataSetBien.DataSetName = "BDDFinalDataSetBien";
            this.bDDFinalDataSetBien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacheBindingSource
            // 
            this.tacheBindingSource.DataMember = "Tache";
            this.tacheBindingSource.DataSource = this.bDDFinalDataSetBien;
            // 
            // tacheTableAdapter
            // 
            this.tacheTableAdapter.ClearBeforeFill = true;
            // 
            // exigenceTableAdapter
            // 
            this.exigenceTableAdapter.ClearBeforeFill = true;
            // 
            // fKTacheExigenceBindingSource
            // 
            this.fKTacheExigenceBindingSource.DataMember = "FK_Tache_Exigence";
            this.fKTacheExigenceBindingSource.DataSource = this.exigenceBindingSource;
            // 
            // exigenceBindingSource1
            // 
            this.exigenceBindingSource1.DataMember = "Exigence";
            this.exigenceBindingSource1.DataSource = this.bDDFinalDataSetBien;
            // 
            // projet
            // 
            this.projet.DataPropertyName = "projet";
            this.projet.HeaderText = "projet";
            this.projet.Name = "projet";
            // 
            // label
            // 
            this.label.DataPropertyName = "label";
            this.label.HeaderText = "label";
            this.label.Name = "label";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // details
            // 
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "details";
            this.details.Name = "details";
            // 
            // livrable
            // 
            this.livrable.DataPropertyName = "livrable";
            this.livrable.HeaderText = "livrable";
            this.livrable.Name = "livrable";
            // 
            // NiveauExi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ModifProj);
            this.Controls.Add(this.AjoutProj);
            this.Name = "NiveauExi";
            this.Text = "NiveauExi";
            this.Load += new System.EventHandler(this.NiveauExi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTacheExigenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exigenceBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button ModifProj;
        private System.Windows.Forms.Button AjoutProj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource tacheBindingSource;
        private BDDFinalDataSetBienTableAdapters.TacheTableAdapter tacheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource exigenceBindingSource;
        private BDDFinalDataSetBienTableAdapters.ExigenceTableAdapter exigenceTableAdapter;
        private System.Windows.Forms.BindingSource fKTacheExigenceBindingSource;
        private System.Windows.Forms.BindingSource exigenceBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projet;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn livrable;
    }
}