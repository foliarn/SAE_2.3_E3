namespace SAE_2._5_E3
{
    partial class PageAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIntro = new Label();
            lblNames = new Label();
            lblTitre = new Label();
            lblDemande = new Label();
            textBox1 = new TextBox();
            btnValider = new Button();
            txtResultat = new TextBox();
            lblIUT = new Label();
            SuspendLayout();
            // 
            // lblIntro
            // 
            lblIntro.AutoSize = true;
            lblIntro.Location = new Point(12, 605);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(172, 25);
            lblIntro.TabIndex = 0;
            lblIntro.Text = "SAE 2.5 - Groupe E3";
            lblIntro.Click += lblIntro_Click;
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Location = new Point(12, 630);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(384, 25);
            lblNames.TabIndex = 1;
            lblNames.Text = "RAUX - HELLERINGER - CABARET - TOUSSAINT";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(445, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(382, 32);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Calculateur de header checksum";
            // 
            // lblDemande
            // 
            lblDemande.AutoSize = true;
            lblDemande.Location = new Point(460, 58);
            lblDemande.Name = "lblDemande";
            lblDemande.Size = new Size(357, 25);
            lblDemande.TabIndex = 3;
            lblDemande.Text = "Veuillez coller votre header en hexadécimal :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 274);
            textBox1.TabIndex = 4;
            // 
            // btnValider
            // 
            btnValider.AutoSize = true;
            btnValider.Location = new Point(544, 402);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(184, 35);
            btnValider.TabIndex = 5;
            btnValider.Text = "Calculer le checksum";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // txtResultat
            // 
            txtResultat.Location = new Point(485, 459);
            txtResultat.Multiline = true;
            txtResultat.Name = "txtResultat";
            txtResultat.ReadOnly = true;
            txtResultat.Size = new Size(311, 139);
            txtResultat.TabIndex = 6;
            txtResultat.Text = "Le checksum de ce header est égal à :\r\n%d (DEC)\r\n%d (HEX)\r\n%d (BIN)";
            // 
            // lblIUT
            // 
            lblIUT.AutoSize = true;
            lblIUT.Location = new Point(1129, 630);
            lblIUT.Name = "lblIUT";
            lblIUT.Size = new Size(117, 25);
            lblIUT.TabIndex = 7;
            lblIUT.Text = "IUT d'Amiens";
            // 
            // PageAccueil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(lblIUT);
            Controls.Add(txtResultat);
            Controls.Add(btnValider);
            Controls.Add(textBox1);
            Controls.Add(lblDemande);
            Controls.Add(lblTitre);
            Controls.Add(lblNames);
            Controls.Add(lblIntro);
            Name = "PageAccueil";
            Text = "Calcul de header checksum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntro;
        private Label lblNames;
        private Label lblTitre;
        private Label lblDemande;
        private TextBox textBox1;
        private Button btnValider;
        private TextBox txtResultat;
        private Label lblIUT;
    }
}
