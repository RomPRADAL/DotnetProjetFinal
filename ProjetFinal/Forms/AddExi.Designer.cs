namespace ProjetFinal.Forms
{
    partial class AddExi
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
            this.textBoxRespon = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.lblRespon = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(29, 193);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(185, 26);
            this.textBoxId.TabIndex = 13;
            // 
            // textBoxRespon
            // 
            this.textBoxRespon.Location = new System.Drawing.Point(587, 193);
            this.textBoxRespon.Name = "textBoxRespon";
            this.textBoxRespon.Size = new System.Drawing.Size(185, 26);
            this.textBoxRespon.TabIndex = 12;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(310, 193);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(185, 26);
            this.textBoxNom.TabIndex = 11;
            // 
            // lblRespon
            // 
            this.lblRespon.AutoSize = true;
            this.lblRespon.Location = new System.Drawing.Point(624, 155);
            this.lblRespon.Name = "lblRespon";
            this.lblRespon.Size = new System.Drawing.Size(103, 20);
            this.lblRespon.TabIndex = 10;
            this.lblRespon.Text = "Responsable";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(368, 155);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(79, 155);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "(Debug) Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddExi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxRespon);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblRespon);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddExi";
            this.Text = "AddExi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxRespon;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label lblRespon;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
    }
}