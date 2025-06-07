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
            lblIUT = new Label();
            btnCopierHex = new Button();
            btnCopierBin = new Button();
            btnCopierDec = new Button();
            lblCopierChecksum = new Label();
            rtxResultat = new RichTextBox();
            SuspendLayout();
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIntro.AutoSize = true;
            lblIntro.Location = new Point(11, 522);
            lblIntro.Margin = new Padding(2, 0, 2, 0);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(110, 15);
            lblIntro.TabIndex = 0;
            lblIntro.Text = "SAE 2.5 - Groupe E3";
            // 
            // lblNames
            // 
            lblNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNames.AutoSize = true;
            lblNames.Location = new Point(11, 537);
            lblNames.Margin = new Padding(2, 0, 2, 0);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(256, 15);
            lblNames.TabIndex = 1;
            lblNames.Text = "RAUX - HELLERINGER - CABARET - TOUSSAINT";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(312, 5);
            lblTitre.Margin = new Padding(2, 0, 2, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(257, 21);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Calculateur de header checksum";
            // 
            // lblDemande
            // 
            lblDemande.AutoSize = true;
            lblDemande.Location = new Point(322, 35);
            lblDemande.Margin = new Padding(2, 0, 2, 0);
            lblDemande.Name = "lblDemande";
            lblDemande.Size = new Size(238, 15);
            lblDemande.TabIndex = 3;
            lblDemande.Text = "Veuillez coller votre header en hexadécimal :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 67);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 166);
            textBox1.TabIndex = 4;
            // 
            // btnValider
            // 
            btnValider.AutoSize = true;
            btnValider.Location = new Point(381, 241);
            btnValider.Margin = new Padding(2);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(129, 25);
            btnValider.TabIndex = 5;
            btnValider.Text = "Calculer le checksum";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // lblIUT
            // 
            lblIUT.AutoSize = true;
            lblIUT.Location = new Point(804, 537);
            lblIUT.Margin = new Padding(2, 0, 2, 0);
            lblIUT.Name = "lblIUT";
            lblIUT.Size = new Size(78, 15);
            lblIUT.TabIndex = 7;
            lblIUT.Text = "IUT d'Amiens";
            // 
            // btnCopierHex
            // 
            btnCopierHex.AutoSize = true;
            btnCopierHex.BackColor = SystemColors.ButtonFace;
            btnCopierHex.Location = new Point(253, 414);
            btnCopierHex.Margin = new Padding(2);
            btnCopierHex.Name = "btnCopierHex";
            btnCopierHex.Size = new Size(129, 25);
            btnCopierHex.TabIndex = 8;
            btnCopierHex.Text = "Hexadécimal";
            btnCopierHex.UseVisualStyleBackColor = false;
            btnCopierHex.Click += btnCopierHex_Click;
            // 
            // btnCopierBin
            // 
            btnCopierBin.AutoSize = true;
            btnCopierBin.Location = new Point(386, 414);
            btnCopierBin.Margin = new Padding(2);
            btnCopierBin.Name = "btnCopierBin";
            btnCopierBin.Size = new Size(129, 25);
            btnCopierBin.TabIndex = 9;
            btnCopierBin.Text = "Binaire";
            btnCopierBin.UseVisualStyleBackColor = true;
            btnCopierBin.Click += btnCopierBin_Click;
            // 
            // btnCopierDec
            // 
            btnCopierDec.AutoSize = true;
            btnCopierDec.Location = new Point(519, 414);
            btnCopierDec.Margin = new Padding(2);
            btnCopierDec.Name = "btnCopierDec";
            btnCopierDec.Size = new Size(129, 25);
            btnCopierDec.TabIndex = 10;
            btnCopierDec.Text = "Décimal";
            btnCopierDec.UseVisualStyleBackColor = true;
            btnCopierDec.Click += btnCopierDec_Click;
            // 
            // lblCopierChecksum
            // 
            lblCopierChecksum.AutoSize = true;
            lblCopierChecksum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopierChecksum.Location = new Point(298, 377);
            lblCopierChecksum.Margin = new Padding(2, 0, 2, 0);
            lblCopierChecksum.Name = "lblCopierChecksum";
            lblCopierChecksum.Size = new Size(304, 15);
            lblCopierChecksum.TabIndex = 11;
            lblCopierChecksum.Text = "Veuillez cliquer sur un bouton pour copier le checksum :";
            // 
            // rtxResultat
            // 
            rtxResultat.Location = new Point(340, 275);
            rtxResultat.Name = "rtxResultat";
            rtxResultat.ReadOnly = true;
            rtxResultat.Size = new Size(219, 85);
            rtxResultat.TabIndex = 12;
            rtxResultat.Text = "";
            // 
            // PageAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(rtxResultat);
            Controls.Add(lblCopierChecksum);
            Controls.Add(btnCopierDec);
            Controls.Add(btnCopierBin);
            Controls.Add(btnCopierHex);
            Controls.Add(lblIUT);
            Controls.Add(btnValider);
            Controls.Add(textBox1);
            Controls.Add(lblDemande);
            Controls.Add(lblTitre);
            Controls.Add(lblNames);
            Controls.Add(lblIntro);
            Margin = new Padding(2);
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
        private Label lblIUT;
        private Button btnCopierHex;
        private Button btnCopierBin;
        private Button btnCopierDec;
        private Label lblCopierChecksum;
        private RichTextBox rtxResultat;
    }
}
