namespace MainWindows
{
    partial class PopAjoutsMedecin
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
            this.bt_Ajouter = new System.Windows.Forms.Button();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.GB_NewMed = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_DepartDoc = new System.Windows.Forms.TextBox();
            this.TB_AdresseDoc = new System.Windows.Forms.TextBox();
            this.TB_TelDoc = new System.Windows.Forms.TextBox();
            this.TB_PrenomDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_NomDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_NewMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ajouter.Location = new System.Drawing.Point(369, 29);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.Size = new System.Drawing.Size(165, 49);
            this.bt_Ajouter.TabIndex = 0;
            this.bt_Ajouter.Text = "ajouter";
            this.bt_Ajouter.UseVisualStyleBackColor = true;
            this.bt_Ajouter.Click += new System.EventHandler(this.bt_Ajouter_Click);
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Annuler.Location = new System.Drawing.Point(369, 129);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(165, 49);
            this.bt_Annuler.TabIndex = 1;
            this.bt_Annuler.Text = "annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // GB_NewMed
            // 
            this.GB_NewMed.Controls.Add(this.label8);
            this.GB_NewMed.Controls.Add(this.label7);
            this.GB_NewMed.Controls.Add(this.label5);
            this.GB_NewMed.Controls.Add(this.TB_DepartDoc);
            this.GB_NewMed.Controls.Add(this.TB_AdresseDoc);
            this.GB_NewMed.Controls.Add(this.TB_TelDoc);
            this.GB_NewMed.Controls.Add(this.TB_PrenomDoc);
            this.GB_NewMed.Controls.Add(this.label3);
            this.GB_NewMed.Controls.Add(this.TB_NomDoc);
            this.GB_NewMed.Controls.Add(this.label2);
            this.GB_NewMed.Location = new System.Drawing.Point(12, 12);
            this.GB_NewMed.Name = "GB_NewMed";
            this.GB_NewMed.Size = new System.Drawing.Size(293, 164);
            this.GB_NewMed.TabIndex = 13;
            this.GB_NewMed.TabStop = false;
            this.GB_NewMed.Text = "Nouveau Médecin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Télèphone";
            // 
            // TB_DepartDoc
            // 
            this.TB_DepartDoc.Location = new System.Drawing.Point(80, 136);
            this.TB_DepartDoc.Name = "TB_DepartDoc";
            this.TB_DepartDoc.Size = new System.Drawing.Size(192, 20);
            this.TB_DepartDoc.TabIndex = 14;
            this.TB_DepartDoc.TextChanged += new System.EventHandler(this.TB_DepartDoc_TextChanged);
            // 
            // TB_AdresseDoc
            // 
            this.TB_AdresseDoc.Location = new System.Drawing.Point(80, 110);
            this.TB_AdresseDoc.Name = "TB_AdresseDoc";
            this.TB_AdresseDoc.Size = new System.Drawing.Size(192, 20);
            this.TB_AdresseDoc.TabIndex = 14;
            this.TB_AdresseDoc.TextChanged += new System.EventHandler(this.TB_AdresseDoc_TextChanged);
            // 
            // TB_TelDoc
            // 
            this.TB_TelDoc.Location = new System.Drawing.Point(80, 84);
            this.TB_TelDoc.Name = "TB_TelDoc";
            this.TB_TelDoc.Size = new System.Drawing.Size(192, 20);
            this.TB_TelDoc.TabIndex = 14;
            this.TB_TelDoc.TextChanged += new System.EventHandler(this.TB_TelDoc_TextChanged);
            // 
            // TB_PrenomDoc
            // 
            this.TB_PrenomDoc.Location = new System.Drawing.Point(80, 58);
            this.TB_PrenomDoc.Name = "TB_PrenomDoc";
            this.TB_PrenomDoc.Size = new System.Drawing.Size(192, 20);
            this.TB_PrenomDoc.TabIndex = 14;
            this.TB_PrenomDoc.TextChanged += new System.EventHandler(this.TB_PrenomDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prenom";
            // 
            // TB_NomDoc
            // 
            this.TB_NomDoc.Location = new System.Drawing.Point(80, 32);
            this.TB_NomDoc.Name = "TB_NomDoc";
            this.TB_NomDoc.Size = new System.Drawing.Size(192, 20);
            this.TB_NomDoc.TabIndex = 10;
            this.TB_NomDoc.TextChanged += new System.EventHandler(this.TB_NomDoc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Adresse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Département";
            // 
            // PopAjoutsMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 190);
            this.Controls.Add(this.GB_NewMed);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.bt_Ajouter);
            this.Name = "PopAjoutsMedecin";
            this.Text = "PopAjoutsMedecin";
            this.GB_NewMed.ResumeLayout(false);
            this.GB_NewMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Ajouter;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.GroupBox GB_NewMed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_DepartDoc;
        private System.Windows.Forms.TextBox TB_AdresseDoc;
        private System.Windows.Forms.TextBox TB_TelDoc;
        private System.Windows.Forms.TextBox TB_PrenomDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_NomDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}