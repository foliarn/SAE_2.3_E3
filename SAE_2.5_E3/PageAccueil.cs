using BiblioSysteme;

namespace SAE_2._5_E3
{
    public partial class PageAccueil : Form
    {
        private static string hexFormat = "";
        private static string decFormat = "";
        private static string binFormat = "";
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            binFormat = "";
            decFormat = "";
            hexFormat = "";
            try
            {
                // Récupérer le texte saisi par l'utilisateur
                string hexInput = textBox1.Text.Trim();

                // Vérifier que l'utilisateur a saisi quelque chose
                if (string.IsNullOrWhiteSpace(hexInput))
                {
                    rtxResultat.Text = "❌ Erreur : Veuillez saisir un header hexadécimal.";
                    rtxResultat.ForeColor = Color.Red;
                    return;
                }

                // Parser le header IP
                byte[] headerBytes = HeaderParser.ParseIPHeader(hexInput);

                // Calculer le checksum avec la position standard (octet 10)
                ushort checksum = CalculChecksum.CalculateHeaderChecksum(headerBytes, HeaderParser.CHECKSUM_POSITION);

                // Convertir en différents formats
                hexFormat = CalculChecksum.FormatChecksum(checksum);
                decFormat = checksum.ToString();
                binFormat = Convert.ToString(checksum, 2).PadLeft(16, '0');

                // Vider le RichTextBox
                rtxResultat.Clear();

                // Ajouter le titre
                InterfaceHelper.AppendColoredText("✅ Le checksum de ce header est égal à :\r\n", Color.Green, rtxResultat ,false);

                // Ajouter chaque format avec sa couleur
                InterfaceHelper.AppendColoredText("• ", Color.Black, rtxResultat, false);
                InterfaceHelper.AppendColoredText(decFormat, Color.Blue, rtxResultat, true);        // BLEU pour décimal
                InterfaceHelper.AppendColoredText(" (DEC)\r\n", Color.Black, rtxResultat, false);

                InterfaceHelper.AppendColoredText("• 0x", Color.Black, rtxResultat, false);
                InterfaceHelper.AppendColoredText(hexFormat, Color.Red, rtxResultat, true);         // ROUGE pour hexadécimal
                InterfaceHelper.AppendColoredText(" (HEX)\r\n", Color.Black, rtxResultat, false);

                InterfaceHelper.AppendColoredText("• ", Color.Black, rtxResultat, false);
                InterfaceHelper.AppendColoredText(binFormat, Color.DarkGreen, rtxResultat, true);   // VERT FONCÉ pour binaire
                InterfaceHelper.AppendColoredText(" (BIN)", Color.Black, rtxResultat, false);

                // Ajouter les infos du header en gris
                string headerInfo = $"\r\n\r\n📋 Informations du header :\r\n" +
                                   $"• Longueur : {headerBytes.Length} octets\r\n" +
                                   $"• Version IP : {headerBytes[0] >> 4}\r\n" +
                                   $"• IHL : {headerBytes[0] & 0x0F} (soit {(headerBytes[0] & 0x0F) * 4} octets)";

                InterfaceHelper.AppendColoredText(headerInfo, Color.Gray, rtxResultat, false);
            }
            catch (ArgumentException ex)
            {
                rtxResultat.Clear();
                InterfaceHelper.AppendColoredText($"❌ Erreur de validation :\r\n{ex.Message}", Color.Red, rtxResultat, false);
            }
            catch (FormatException ex)
            {
                rtxResultat.Clear();
                InterfaceHelper.AppendColoredText($"❌ Erreur de format :\r\n{ex.Message}", Color.Red, rtxResultat, false);
            }
            catch (Exception ex)
            {
                rtxResultat.Clear();
                InterfaceHelper.AppendColoredText($"❌ Erreur inattendue :\r\n{ex.Message}", Color.Red, rtxResultat, false);
            }
        }

        private void btnCopierHex_Click(object sender, EventArgs e)
        {
            // Copier le checksum en format hexadécimal dans le presse-papiers
            if (!string.IsNullOrEmpty(hexFormat))
            {
                Clipboard.SetText(hexFormat);
                MessageBox.Show("Checksum hexadécimal copié dans le presse-papiers !", "Copie réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun checksum valide à copier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCopierBin_Click(object sender, EventArgs e)
        {
            // Copier le checksum en format binaire dans le presse-papiers
            if (!string.IsNullOrEmpty(binFormat))
            {
                Clipboard.SetText(binFormat);
                MessageBox.Show("Checksum binaire copié dans le presse-papiers !", "Copie réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun checksum valide à copier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCopierDec_Click(object sender, EventArgs e)
        {
            // Copier le checksum en format décimal dans le presse-papiers
            if (!string.IsNullOrEmpty(decFormat))
            {
                Clipboard.SetText(decFormat);
                MessageBox.Show("Checksum décimal copié dans le presse-papiers !", "Copie réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun checksum valide à copier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}