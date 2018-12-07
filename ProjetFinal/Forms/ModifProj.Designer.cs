namespace ProjetFinal.Forms
{
    partial class ModifProj
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblRespon = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.cbResp = new System.Windows.Forms.ComboBox();
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(39, 128);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(185, 26);
            this.textBoxId.TabIndex = 13;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(312, 128);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(185, 26);
            this.textBoxNom.TabIndex = 11;
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Location = new System.Drawing.Point(626, 90);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(103, 20);
            this.lblRespon.TabIndex = 10;
            this.lblRespon.Text = "Responsable";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(370, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(110, 90);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(346, 197);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(100, 33);
            this.btnModif.TabIndex = 7;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // cbResp
            // 
            this.cbResp.DataSource = this.userBindingSource;
            this.cbResp.DisplayMember = "nom";
            this.cbResp.FormattingEnabled = true;
            this.cbResp.Location = new System.Drawing.Point(571, 128);
            this.cbResp.Name = "cbResp";
            this.cbResp.Size = new System.Drawing.Size(185, 28);
            this.cbResp.TabIndex = 14;
            this.cbResp.ValueMember = "nom";
            // 
            // bDDFinalDataSetBien
            // 
            this.bDDFinalDataSetBien.DataSetName = "BDDFinalDataSetBien";
            this.bDDFinalDataSetBien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.bDDFinalDataSetBien;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // ModifProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 277);
            this.Controls.Add(this.cbResp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblRespon);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnModif);
            this.Name = "ModifProj";
            this.Text = "Modif Projet";
            this.Load += new System.EventHandler(this.ModifProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ComboBox cbResp;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource userBindingSource;
        private BDDFinalDataSetBienTableAdapters.UserTableAdapter userTableAdapter;
    }
}