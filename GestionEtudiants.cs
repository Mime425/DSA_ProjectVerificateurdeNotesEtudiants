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
            double moyenne = 0;

            if (liste.getCount() == 0)
            {
                throw new ArgumentException("Il n'y a pas d'étudiants.");
            }

            NoeudEtudiant noeud = liste.getHead();

            while (noeud != null)
            {
                somme += noeud.getData().getNoteFinal();
                noeud = noeud.getNext();
            }

            return somme / moyenne;
        }
        //Recherche linéaire par ID, pour trouver les enregistrement
        //spécifiques d'étudiants
        //On va allé de noeud à noeud jusqu'à ce qu'on arrive au bon ID
        public Etudiant RechercheLineaireParID(int id) 
        {
            NoeudEtudiant temp = liste.getHead();  //commence par le 1er noeud de la liste

            // parcourir la liste pour que le var temp n'est as null
            while (temp != null)
            {
                if (temp.getData().getId() == id)
                {
                    return temp.getData();
                }
                temp = temp.getNext();
            }
            return null;
        }

        public double[] FindMinMax()
        {
            if (liste.getCount() == 0)
            {
                throw new ArgumentException("Il n'y a pas d'étudiants.");
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            NoeudEtudiant temp = liste.getHead();

            while (temp != null)
            {
                double note = temp.getData().getNoteFinal();

                if (note < min)
                {
                    min = note;
                }

                if (note > max)
                {
                    max = note;
                }

                temp = temp.getNext();
            }

            return new double[] { min, max };
        }
        ////Conversion de la liste double Etudiant en tableau (array)
        //public Etudiant[] ConversionListe()
        //{
        //    Etudiant [] tableauEtutudiants = new Etudiant[liste.GetCount()];
        //    NoeudEtudiant temp = ListeDoubleEtudiants.GetHead();
        //int i = 0;

        //while (temp != null)
        //    {
        //        tableauEtudiants[i] = temp.getData();
        //        i++;
        //        temp = temp.getNext();  
        //    }
        //return tableauEtutudiants;
        
        //}

        //// partition Quick Sort comme Tutorials Point
        //private static int Partition(Etudiant[] a, int left, int right, int pivot)
        //{
        //    int leftPointer = left - 1;
        //    int rightPointer = right;

        //    while (true)
        //    {
        //        while (Etudiant[++leftPointer] < pivot) { }

        //        while (rightPointer > 0 && Etudiant[--rightPointer] > pivot) { }

        //        if (leftPointer >= rightPointer)
        //        {
        //            break;

        //        }
        //        else
        //        {
        //            Swap(a, leftPointer, rightPointer);
        //        }
        //    }
        //    Swap(a, leftPointer, right);
        //    return leftPointer;

        //}

        ////QuickSort

        //public static void QuickSort(int[] a, int left, int right)
        //{
        //    if (right - left <= 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        int pivot = a[right];
        //        int partitionPoint = Partition(a, left, right, pivot);

        //        QuickSort(a, left, partitionPoint - 1);
        //        QuickSort(a, partitionPoint + 1, right);

        //    }
        //}

        ////le swap
        //public static void Swap(Etudiant[] a, int num1, int num2)
        //{
        //    Etudiant temp = a[num1];
        //    a[num1] = a[num2];
        //    a[num2] = temp;

        //}
    }
}

