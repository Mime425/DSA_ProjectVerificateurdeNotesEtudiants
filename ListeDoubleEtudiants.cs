using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants;

    public class ListeDoubleEtudiants
    {
        // pointeur vers la premier noeud
        private NoeudEtudiant head;
        private NoeudEtudiant tail;
        private int count;

        // pointeur vers le dernier noeud
        public ListeDoubleEtudiants()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // nombre d'étudiants dans la liste
        public NoeudEtudiant getHead()
        {
            return head;
        }

        // retourne le nombre d'étudiants
        public int getCount() 
        {
            return count;
        }

        // ajouter un étudiant à la fin de la liste
       
        public void AddLast(Etudiant e)
        {
            // créer un nouveau noeud 
            NoeudEtudiant nouveau = new NoeudEtudiant(e);

            // si la liste est vide
            if (head == null)
            {
                // le premier et dernier pointent vers le meme neoud
                head = nouveau;
                tail = nouveau;
            }
            else 
            {
               

                tail.SetNext(nouveau);
                nouveau.SetPrevious(tail);
                tail = nouveau;
            }
            count++;  // augmenter nb d'étudianta

        }

        // afficher tous les étudiants
        
        public void AfficherEtudiants()
        {
            NoeudEtudiant temp = head;

            // check si la liste est vide
            if (temp == null)
            {
                Console.WriteLine("Il n'y a pas d'étudiants dans la liste");
                return;
            }
            Console.WriteLine("Nombre d'étudiants:" + count);

            
            while (temp != null)
            {
                Console.WriteLine(temp.getData());
                temp =  temp.getNext();
            }


        }

        // rechercher un étudiant par son ID
        public NoeudEtudiant RechercheParId(int id)
        {
            NoeudEtudiant temp = head;

            
            while (temp != null)
            {
                if (temp.getData().getId() == id) // checker pour l'étudiant
                {
                    return temp;
                }

                temp = temp.getNext();
             
            }
            return null;
            
        }

        // supprimer un étudiant par son id
        public bool RemoveById(int id)
        {
            // chercher le noeud qu'on doit supprimer 
            NoeudEtudiant noeudASupprimer = RechercheParId(id);

            if (noeudASupprimer == null)  // voir si l'étudiant existe
            {
                return false;
            }

            if (head == tail)   //noeud ds la liste
            {
                head = null;
                tail = null;
            }

            else if (noeudASupprimer == head) // suprimmer 1er noeud
            {
                head = head.getNext();
                head.SetPrevious(null);

            }
            else if (noeudASupprimer == tail)    //supprimer dernier noeud
            {
                tail = tail.getNext();
                tail.SetPrevious(null);
            } 
            else      // récupérer les neouds
            {
                NoeudEtudiant precendant =  noeudASupprimer.getPrevious();
                NoeudEtudiant suivant = noeudASupprimer.getNext();  
            }

            count--;
            return true;
        }



    }


