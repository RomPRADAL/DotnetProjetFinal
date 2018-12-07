namespace ProjetFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DetailProj = new System.Windows.Forms.Button();
            this.AjoutProj = new System.Windows.Forms.Button();
            this.ModifProj = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSetBienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.projetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDFinalDataSet1 = new ProjetFinal.BDDFinalDataSet1();
            this.bDDFinalDataSet = new ProjetFinal.BDDFinalDataSet();
            this.bDDFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetTableAdapter = new ProjetFinal.BDDFinalDataSet1TableAdapters.ProjetTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.projetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projetTableAdapter1 = new ProjetFinal.BDDFinalDataSetBienTableAdapters.ProjetTableAdapter();
            this.btnForceRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailProj
            // 
            this.DetailProj.Location = new System.Drawing.Point(12, 145);
            this.DetailProj.Name = "DetailProj";
            this.DetailProj.Size = new System.Drawing.Size(219, 37);
            this.DetailProj.TabIndex = 1;
            this.DetailProj.Text = "Details";
            this.DetailProj.UseVisualStyleBackColor = true;
            this.DetailProj.Click += new System.EventHandler(this.DetailProj_Click);
            // 
            // AjoutProj
            // 
            this.AjoutProj.Location = new System.Drawing.Point(12, 206);
            this.AjoutProj.Name = "AjoutProj";
            this.AjoutProj.Size = new System.Drawing.Size(219, 37);
            this.AjoutProj.TabIndex = 2;
            this.AjoutProj.Text = "Ajout";
            this.AjoutProj.UseVisualStyleBackColor = true;
            this.AjoutProj.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModifProj
            // 
            this.ModifProj.Location = new System.Drawing.Point(12, 267);
            this.ModifProj.Name = "ModifProj";
            this.ModifProj.Size = new System.Drawing.Size(219, 37);
            this.ModifProj.TabIndex = 3;
            this.ModifProj.Text = "Modifier";
            this.ModifProj.UseVisualStyleBackColor = true;
            this.ModifProj.Click += new System.EventHandler(this.ModifProj_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(12, 328);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(219, 37);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.responsableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(263, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(580, 369);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            this.responsableDataGridViewTextBoxColumn.DataPropertyName = "responsable";
            this.responsableDataGridViewTextBoxColumn.HeaderText = "responsable";
            this.responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            // 
            // projetBindingSource1
            // 
            this.projetBindingSource1.DataMember = "Projet";
            this.projetBindingSource1.DataSource = this.bDDFinalDataSetBienBindingSource;
            // 
            // bDDFinalDataSetBienBindingSource
            // 
            this.bDDFinalDataSetBienBindingSource.DataSource = this.bDDFinalDataSetBien;
            this.bDDFinalDataSetBienBindingSource.Position = 0;
            // 
            // bDDFinalDataSetBien
            // 
            this.bDDFinalDataSetBien.DataSetName = "BDDFinalDataSetBien";
            this.bDDFinalDataSetBien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetBindingSource
            // 
            this.projetBindingSource.DataMember = "Projet";
            this.projetBindingSource.DataSource = this.bDDFinalDataSet1;
            // 
            // bDDFinalDataSet1
            // 
            this.bDDFinalDataSet1.DataSetName = "BDDFinalDataSet1";
            this.bDDFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDFinalDataSet
            // 
            this.bDDFinalDataSet.DataSetName = "BDDFinalDataSet";
            this.bDDFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDFinalDataSetBindingSource
            // 
            this.bDDFinalDataSetBindingSource.DataSource = this.bDDFinalDataSet;
            this.bDDFinalDataSetBindingSource.Position = 0;
            // 
            // projetTableAdapter
            // 
            this.projetTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // projetBindingSource2
            // 
            this.projetBindingSource2.DataMember = "Projet";
            this.projetBindingSource2.DataSource = this.bDDFinalDataSetBienBindingSource;
            // 
            // projetTableAdapter1
            // 
            this.projetTableAdapter1.ClearBeforeFill = true;
            // 
            // btnForceRefresh
            // 
            this.btnForceRefresh.Location = new System.Drawing.Point(713, 12);
            this.btnForceRefresh.Name = "btnForceRefresh";
            this.btnForceRefresh.Size = new System.Drawing.Size(130, 42);
            this.btnForceRefresh.TabIndex = 6;
            this.btnForceRefresh.Text = "Force refresh";
            this.btnForceRefresh.UseVisualStyleBackColor = true;
            this.btnForceRefresh.Click += new System.EventHandler(this.btnForceRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 441);
            this.Controls.Add(this.btnForceRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ModifProj);
            this.Controls.Add(this.AjoutProj);
            this.Controls.Add(this.DetailProj);
            this.Name = "Form1";
            this.Text = "Ecran Projet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DetailProj;
        private System.Windows.Forms.Button AjoutProj;
        private System.Windows.Forms.Button ModifProj;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDDFinalDataSetBindingSource;
        private BDDFinalDataSet bDDFinalDataSet;
        private BDDFinalDataSet1 bDDFinalDataSet1;
        private System.Windows.Forms.BindingSource projetBindingSource;
        private BDDFinalDataSet1TableAdapters.ProjetTableAdapter projetTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource bDDFinalDataSetBienBindingSource;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource projetBindingSource1;
        private BDDFinalDataSetBienTableAdapters.ProjetTableAdapter projetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projetBindingSource2;
        private System.Windows.Forms.Button btnForceRefresh;
    }
}

