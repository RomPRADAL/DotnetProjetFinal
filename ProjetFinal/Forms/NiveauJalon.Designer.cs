namespace ProjetFinal.Forms
{
    partial class NiveauJalon
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
            this.DetailProj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avancementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.livrableTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.LivrableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(22, 312);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(219, 37);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // ModifProj
            // 
            this.ModifProj.Location = new System.Drawing.Point(22, 251);
            this.ModifProj.Name = "ModifProj";
            this.ModifProj.Size = new System.Drawing.Size(219, 37);
            this.ModifProj.TabIndex = 11;
            this.ModifProj.Text = "Modifier";
            this.ModifProj.UseVisualStyleBackColor = true;
            this.ModifProj.Click += new System.EventHandler(this.ModifProj_Click);
            // 
            // AjoutProj
            // 
            this.AjoutProj.Location = new System.Drawing.Point(22, 190);
            this.AjoutProj.Name = "AjoutProj";
            this.AjoutProj.Size = new System.Drawing.Size(219, 37);
            this.AjoutProj.TabIndex = 10;
            this.AjoutProj.Text = "Ajout";
            this.AjoutProj.UseVisualStyleBackColor = true;
            this.AjoutProj.Click += new System.EventHandler(this.AjoutProj_Click);
            // 
            // DetailProj
            // 
            this.DetailProj.Enabled = false;
            this.DetailProj.Location = new System.Drawing.Point(22, 129);
            this.DetailProj.Name = "DetailProj";
            this.DetailProj.Size = new System.Drawing.Size(219, 37);
            this.DetailProj.TabIndex = 9;
            this.DetailProj.Text = "Details";
            this.DetailProj.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.dateLivDataGridViewTextBoxColumn,
            this.avancementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livrableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(343, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(695, 366);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "label";
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            // 
            // dateLivDataGridViewTextBoxColumn
            // 
            this.dateLivDataGridViewTextBoxColumn.DataPropertyName = "dateLiv";
            this.dateLivDataGridViewTextBoxColumn.HeaderText = "dateLiv";
            this.dateLivDataGridViewTextBoxColumn.Name = "dateLivDataGridViewTextBoxColumn";
            // 
            // avancementDataGridViewTextBoxColumn
            // 
            this.avancementDataGridViewTextBoxColumn.DataPropertyName = "avancement";
            this.avancementDataGridViewTextBoxColumn.HeaderText = "avancement";
            this.avancementDataGridViewTextBoxColumn.Name = "avancementDataGridViewTextBoxColumn";
            // 
            // livrableBindingSource
            // 
            this.livrableBindingSource.DataMember = "Livrable";
            this.livrableBindingSource.DataSource = this.bDDFinalDataSetBien;
            // 
            // bDDFinalDataSetBien
            // 
            this.bDDFinalDataSetBien.DataSetName = "BDDFinalDataSetBien";
            this.bDDFinalDataSetBien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrableTableAdapter
            // 
            this.livrableTableAdapter.ClearBeforeFill = true;
            // 
            // NiveauJalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ModifProj);
            this.Controls.Add(this.AjoutProj);
            this.Controls.Add(this.DetailProj);
            this.Name = "NiveauJalon";
            this.Text = "NiveauJalon";
            this.Load += new System.EventHandler(this.NiveauJalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button ModifProj;
        private System.Windows.Forms.Button AjoutProj;
        private System.Windows.Forms.Button DetailProj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource livrableBindingSource;
        private BDDFinalDataSetBienTableAdapters.LivrableTableAdapter livrableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avancementDataGridViewTextBoxColumn;
    }
}