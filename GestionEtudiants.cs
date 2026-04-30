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
        
        private ListeDoubleEtudiants listEtudiants;
        private Hashtable tableHachage;
        private Etudiant[] etudiants;


        //constructor
        public GestionEtudiants(int size)
        {
            listEtudiants = new ListeDoubleEtudiants();
            tableHachage = new Hashtable();
        }

        public void ajouterEtudiant(Etudiant e)
        {
            if (tableHachage.ContainsKey(e.GetId()))
            {
                Console.WriteLine("Un étudiant avec ce ID existe déjà");
            }
            else
            {
                listEtudiants.AddLast(e);
                tableHachage.Add(e.GetId(), e); 
                Console.WriteLine("Étudiant ajouté avec succès");
            }
                
        }


        public void afficherEtudiants()
        {
            for (int i = 0; i < nombreEtudiants; i++)
            {
                Console.WriteLine(etudiant[i].ToString());
            }
        }

        public Etudiant LinearSearchID(int id)
        {
            for (int i = 0; i < nombreEtudiants; i++)
            {
                if (etudiant[i].getId() == id)
                {
                    return etudiant[i];
                }
            }
            return null;
        }

        //comme tutorialspoint.com
        public void QuickSortByID()
        {
            QuickSort(0, nombreEtudiants - 1);
        }
        public void Swap(int num1, int num2)
        {
            Etudiant temp = etudiant[num1];
            etudiant[num1] = etudiant[num2];
            etudiant[num2] = temp;
        }
        private int Partition(int left, int right, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (etudiant[++leftPointer].getId() < pivot) { }
                while (rightPointer > 0 && etudiant[--rightPointer].getId() > pivot) { }

                if (leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {
                    Swap(leftPointer, rightPointer);
                }
            }
            Swap(leftPointer, right);
            return leftPointer;
        }
        public void QuickSort(int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = etudiant[right].getId();
                int partitionPoint = Partition(left, right, pivot);
                QuickSort(left, partitionPoint - 1);
                QuickSort(partitionPoint + 1, right);
            }
        }

        public int getNombreEtudiants()
        {
            return nombreEtudiants;
        }

        public Etudiant getEtudiantById(int id)
        {
            if (tableHachage.ContainsKey(id))
            {
                return tableauHash[id];
            }
            else
            {
                return null;
            }
        }
    }
}

