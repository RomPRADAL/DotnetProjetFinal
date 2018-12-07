namespace ProjetFinal.Forms
{
    partial class AddProjet
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblRespon = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.cbResp = new System.Windows.Forms.ComboBox();
            this.bDDFinalDataSetBien = new ProjetFinal.BDDFinalDataSetBien();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new ProjetFinal.BDDFinalDataSetBienTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(81, 153);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "(Debug) Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(219, 53);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Location = new System.Drawing.Point(475, 53);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(103, 20);
            this.lblRespon.TabIndex = 3;
            this.lblRespon.Text = "Responsable";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(161, 91);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(185, 26);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(31, 191);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(185, 26);
            this.textBoxId.TabIndex = 6;
            // 
            // cbResp
            // 
            this.cbResp.DataSource = this.userBindingSource;
            this.cbResp.DisplayMember = "nom";
            this.cbResp.FormattingEnabled = true;
            this.cbResp.Location = new System.Drawing.Point(457, 91);
            this.cbResp.Name = "cbResp";
            this.cbResp.Size = new System.Drawing.Size(185, 28);
            this.cbResp.TabIndex = 7;
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
            // AddProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.cbResp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblRespon);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddProjet";
            this.Text = "Ajout Projet";
            this.Load += new System.EventHandler(this.AddProjet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDFinalDataSetBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox cbResp;
        private BDDFinalDataSetBien bDDFinalDataSetBien;
        private System.Windows.Forms.BindingSource userBindingSource;
        private BDDFinalDataSetBienTableAdapters.UserTableAdapter userTableAdapter;
    }
}