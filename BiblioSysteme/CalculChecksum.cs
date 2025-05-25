using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSysteme
{
    /// <summary>
    /// Calcule le checksomme d'un header selon l'algorithme Internet Checksomme (RFC 1071).
    /// </summary>
    public static class CalculChecksomme
    {
        ///<summary>
        ///Calcule le checksomme d'un tableau d'octets.
        ///</summary>
        ///<param name="data">Tableau d'octets à traiter.</param>"
        ///<returns>Checksomme calculé (16 bits)</returns>
        ///<exception cref="ArgumentNullException">Si les données sont nulles</exception>
        public static ushort CalculateChecksomme(byte[] data)
        {
            // Vérifier si les données sont nulles ou vides
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "Les données ne peuvent pas être nulles.");
            }

            if (data.Length == 0)
            {
                throw new ArgumentException("Le tableau de données ne peut pas être vide.", nameof(data));
            }

            // Initialiser la somme à 0
            uint somme = 0;

            // Traiter les octets par paires (16 bits)
            for (int i = 0; i < data.Length; i += 2)
            {
                // Combiner deux octets en un mot de 16 bits
                ushort mot = (ushort)((data[i] << 8) | data[i + 1]);
                somme += mot;
            }

            // Si il reste un octet impair, l'ajouter à la somme avec un zéro pour le compléter
            if (data.Length % 2 != 0)
            {
                somme += (ushort)(data[data.Length - 1] << 8);
            }

            // Ajouter les retenues
            while ((somme >> 16) > 0)
            {
                somme = (somme & 0xFFFF) + (somme >> 16);
            }

            // Retourner le complément à un de la somme
            return (ushort)(~somme & 0xFFFF);
        }

        ///<summary>
        ///Calcule le checksum d'un header avec le champ "Checksum" mis à zéro. (utile dans notre cas !)
        ///</summary>
        ///<param name="headerData">Données du header</param>
        ///<param name="checksumPosition">Position du champ "Checksum" dans le header</param>"
        ///<returns>Checksum calculé</returns>
        ///<exception cref="ArgumentNullException">Si les données sont nulles</exception>
        ///<exception cref="ArgumentOutOfRangeException">Si la position du checksum est invalide</exception>"
        public static ushort CalculateHeaderChecksum(byte[] headerData, int checksumPosition)
        {
            // Vérifier si les données sont nulles ou vides
            if (headerData == null)
            {
                throw new ArgumentNullException(nameof(headerData), "Les données du header ne peuvent pas être nulles.");
            }
            if (headerData.Length == 0)
            {
                throw new ArgumentException("Le tableau de données du header ne peut pas être vide.", nameof(headerData));
            }
            // Vérifier si la position du checksum est valide
            if (checksumPosition < 0 || checksumPosition + 1 >= headerData.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(checksumPosition), "La position du checksum est invalide.");
            }
            // Créer une copie avec le checksum mis à zéro
            byte[] dataSansChecksum = new byte[headerData.Length];
            Array.Copy(headerData, dataSansChecksum, headerData.Length);

            // S'assurer que les octets du checksum sont mis à zéro
            dataSansChecksum[checksumPosition] = 0;
            dataSansChecksum[checksumPosition + 1] = 0;

            // Calculer le checksum
            return CalculateChecksomme(dataSansChecksum);
        }

        ///<summary>
        /// Formate le checksum en une chaîne hexadécimale de 4 caractères.
        /// </summary>
        /// <param name="checksum">Le checksum à formater.</param>"
        /// <returns>Chaine hexadécimale formatée (ex : "E1B2")</returns>
        public static string FormatChecksum(ushort checksum)
        {
            return checksum.ToString("X4").ToUpperInvariant();
        }

    }
}
