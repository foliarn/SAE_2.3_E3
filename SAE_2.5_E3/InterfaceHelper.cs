using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_2._5_E3
{
    internal class InterfaceHelper
    {
        // 3. MÉTHODE HELPER pour ajouter du texte coloré
        public static void AppendColoredText(string text, Color color, RichTextBox rtx, bool bold)
        {
            // Sauvegarder la position actuelle
            int start = rtx.TextLength;

            // Ajouter le texte
            rtx.AppendText(text);

            // Sélectionner le texte qu'on vient d'ajouter
            rtx.Select(start, text.Length);

            // Appliquer la couleur
            rtx.SelectionColor = color;

            // Appliquer le gras si demandé
            if (bold)
            {
                rtx.SelectionFont = new Font(rtx.Font, FontStyle.Bold);
            }

            // Déselectionner pour éviter que le prochain texte hérite du formatage
            rtx.Select(rtx.TextLength, 0);
        }
    }
}
