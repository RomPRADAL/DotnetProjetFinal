namespace ProjetFinal.Forms
{
    partial class NiveauTache
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
            this.DetailTache = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exigenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.tacheTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.TacheTableAdapter();
            this.btnJalon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(27, 313);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(219, 37);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // ModifProj
            // 
            this.ModifProj.Location = new System.Drawing.Point(27, 252);
            this.ModifProj.Name = "ModifProj";
            this.ModifProj.Size = new System.Drawing.Size(219, 37);
            this.ModifProj.TabIndex = 7;
            this.ModifProj.Text = "Modifier";
            this.ModifProj.UseVisualStyleBackColor = true;
            this.ModifProj.Click += new System.EventHandler(this.ModifProj_Click);
            // 
            // AjoutProj
            // 
            this.AjoutProj.Location = new System.Drawing.Point(27, 191);
            this.AjoutProj.Name = "AjoutProj";
            this.AjoutProj.Size = new System.Drawing.Size(219, 37);
            this.AjoutProj.TabIndex = 6;
            this.AjoutProj.Text = "Ajout";
            this.AjoutProj.UseVisualStyleBackColor = true;
            this.AjoutProj.Click += new System.EventHandler(this.AjoutProj_Click);
            // 
            // DetailTache
            // 
            this.DetailTache.Location = new System.Drawing.Point(27, 130);
            this.DetailTache.Name = "DetailTache";
            this.DetailTache.Size = new System.Drawing.Size(219, 37);
            this.DetailTache.TabIndex = 5;
            this.DetailTache.Text = "Details";
            this.DetailTache.UseVisualStyleBackColor = true;
            this.DetailTache.Click += new System.EventHandler(this.DetailProj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn,
            this.exigenceDataGridViewTextBoxColumn,
            this.dateDebDataGridViewTextBoxColumn,
            this.dateReelDataGridViewTextBoxColumn,
            this.chargeDataGridViewTextBoxColumn,
            this.termineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tacheBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(292, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 401);
            this.dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            // 
            // exigenceDataGridViewTextBoxColumn
            // 
            this.exigenceDataGridViewTextBoxColumn.DataPropertyName = "exigence";
            this.exigenceDataGridViewTextBoxColumn.HeaderText = "exigence";
            this.exigenceDataGridViewTextBoxColumn.Name = "exigenceDataGridViewTextBoxColumn";
            // 
            // dateDebDataGridViewTextBoxColumn
            // 
            this.dateDebDataGridViewTextBoxColumn.DataPropertyName = "dateDeb";
            this.dateDebDataGridViewTextBoxColumn.HeaderText = "dateDeb";
            this.dateDebDataGridViewTextBoxColumn.Name = "dateDebDataGridViewTextBoxColumn";
            // 
            // dateReelDataGridViewTextBoxColumn
            // 
            this.dateReelDataGridViewTextBoxColumn.DataPropertyName = "dateReel";
            this.dateReelDataGridViewTextBoxColumn.HeaderText = "dateReel";
            this.dateReelDataGridViewTextBoxColumn.Name = "dateReelDataGridViewTextBoxColumn";
            // 
            // chargeDataGridViewTextBoxColumn
            // 
            this.chargeDataGridViewTextBoxColumn.DataPropertyName = "charge";
            this.chargeDataGridViewTextBoxColumn.HeaderText = "charge";
            this.chargeDataGridViewTextBoxColumn.Name = "chargeDataGridViewTextBoxColumn";
            // 
            // termineDataGridViewTextBoxColumn
            // 
            this.termineDataGridViewTextBoxColumn.DataPropertyName = "termine";
            this.termineDataGridViewTextBoxColumn.HeaderText = "termine";
            this.termineDataGridViewTextBoxColumn.Name = "termineDataGridViewTextBoxColumn";
            // 
            // tacheBindingSource
            // 
            this.tacheBindingSource.DataMember = "Tache";
            this.tacheBindingSource.DataSource = this.bDDFinalDataSetBien;
            // 
            // bDDFinalDataSetBien
            // 
            this.bDDFinalDataSetBien.DataSetName = "BDDFinalDataSetBien";
            this.bDDFinalDataSetBien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tacheTableAdapter
            // 
            this.tacheTableAdapter.ClearBeforeFill = true;
            // 
            // btnJalon
            // 
            this.btnJalon.Location = new System.Drawing.Point(27, 72);
            this.btnJalon.Name = "btnJalon";
            this.btnJalon.Size = new System.Drawing.Size(219, 37);
            this.btnJalon.TabIndex = 10;
            this.btnJalon.Text = "Jalon";
            this.btnJalon.UseVisualStyleBackColor = true;
            this.btnJalon.Click += new System.EventHandler(this.btnJalon_Click);
            // 
            // NiveauTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.btnJalon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ModifProj);
            this.Controls.Add(this.AjoutProj);
            this.Controls.Add(this.DetailTache);
            this.Name = "NiveauTache";
            this.Text = "NiveauTache";
            this.Load += new System.EventHandler(this.NiveauTache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button ModifProj;
        private System.Windows.Forms.Button AjoutProj;
        private System.Windows.Forms.Button DetailTache;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource tacheBindingSource;
        private BDDFinalDataSetBienTableAdapters.TacheTableAdapter tacheTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exigenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termineDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnJalon;
    }
}