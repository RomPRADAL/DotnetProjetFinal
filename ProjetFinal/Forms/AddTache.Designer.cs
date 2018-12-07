namespace ProjetFinal.Forms
{
    partial class AddTache
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDescri = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblRespon = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.textBoxExi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDeb = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReel = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTerm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(37, 360);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(185, 26);
            this.textBoxId.TabIndex = 13;
            // 
            // textBoxDescri
            // 
            this.textBoxDescri.Location = new System.Drawing.Point(254, 76);
            this.textBoxDescri.Name = "textBoxDescri";
            this.textBoxDescri.Size = new System.Drawing.Size(185, 26);
            this.textBoxDescri.TabIndex = 12;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(27, 76);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(185, 26);
            this.textBoxNom.TabIndex = 11;
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Location = new System.Drawing.Point(291, 38);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(89, 20);
            this.lblRespon.TabIndex = 10;
            this.lblRespon.Text = "Description";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(85, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 312);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "(Debug) Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(487, 76);
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(185, 26);
            this.textBoxResp.TabIndex = 14;
            // 
            // textBoxExi
            // 
            this.textBoxExi.Location = new System.Drawing.Point(27, 197);
            this.textBoxExi.Name = "textBoxExi";
            this.textBoxExi.Size = new System.Drawing.Size(185, 26);
            this.textBoxExi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exigence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Responsable";
            // 
            // dateTimeDeb
            // 
            this.dateTimeDeb.Location = new System.Drawing.Point(260, 197);
            this.dateTimeDeb.Name = "dateTimeDeb";
            this.dateTimeDeb.Size = new System.Drawing.Size(200, 26);
            this.dateTimeDeb.TabIndex = 20;
            // 
            // dateTimeReel
            // 
            this.dateTimeReel.Location = new System.Drawing.Point(487, 195);
            this.dateTimeReel.Name = "dateTimeReel";
            this.dateTimeReel.Size = new System.Drawing.Size(200, 26);
            this.dateTimeReel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date reel";
            // 
            // checkBoxTerm
            // 
            this.checkBoxTerm.AutoSize = true;
            this.checkBoxTerm.Location = new System.Drawing.Point(322, 288);
            this.checkBoxTerm.Name = "checkBoxTerm";
            this.checkBoxTerm.Size = new System.Drawing.Size(149, 24);
            this.checkBoxTerm.TabIndex = 23;
            this.checkBoxTerm.Text = "Tache terminé ?";
            this.checkBoxTerm.UseVisualStyleBackColor = true;
            // 
            // AddTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.checkBoxTerm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeReel);
            this.Controls.Add(this.dateTimeDeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExi);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxDescri);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblRespon);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddTache";
            this.Text = "AddTache";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDescri;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.TextBox textBoxExi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDeb;
        private System.Windows.Forms.DateTimePicker dateTimeReel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxTerm;
    }
}