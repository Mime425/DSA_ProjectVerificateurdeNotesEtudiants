using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    public class GestionEtudiants
    {
        //attributs

    
        private Dictionary<int, Etudiant> tableauHash;
        //private Hashtable tableHachage;

        private ListeDoubleEtudiants liste;
       

        public GestionEtudiants()
        {
            liste = new ListeDoubleEtudiants();
            tableauHash = new Dictionary<int, Etudiant>();
        }

        public void ajouterEtudiant(Etudiant e)
        {
            liste.AddLast(e);
            tableauHash[e.getId()] = e;
        }

        public void afficherEtudiants()
        {
            liste.AfficherEtudiants();
        }

        public Etudiant getEtudiantById(int id)
        {
            if (tableauHash.ContainsKey(id))
            {
                return tableauHash[id];
            }
            else
            {
                return null;
            }
        }

        public void supprimerEtudiant(int id)
        {
            if (liste.RemoveById(id))
            {
                tableauHash.Remove(id);
                Console.WriteLine("Étudiant supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Étudiant avec l'ID spécifié non trouvé.");
            }
        }

        public double CalculMoyenneClasse()
        {
            double somme = 0;
            int count = liste.GetCount();

            if (count == 0)
            {
                throw new ArgumentException("Il n'y a pas d'étudiants.");
            }

            NoeudEtudiant temp = liste.GetHead();

            while (temp != null)
            {
                somme += temp.GetData().getNoteFinal();
                temp = temp.GetNext();
            }

            return somme / count;
        }

        public double[] FindMinMax()
        {
            if (liste.GetCount() == 0)
            {
                throw new ArgumentException("Il n'y a pas d'étudiants.");
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            NoeudEtudiant temp = liste.GetHead();

            while (temp != null)
            {
                double note = temp.GetData().getNoteFinal();

                if (note < min)
                {
                    min = note;
                }

                if (note > max)
                {
                    max = note;
                }

                temp = temp.GetNext();
            }

            return new double[] { min, max };
        }
    }
}

