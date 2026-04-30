using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    public class NoeudEtudiant
    {
        // attributs
        public Etudiant data;
        private NoeudEtudiant next;
        private NoeudEtudiant previous;

        //constructeur 
        public NoeudEtudiant(Etudiant data)
        {
            this.data = data;
            next = this;
            previous = null;

        }
        //getters 
        public Etudiant GetData() 
        {
            return data;
        }

        public NoeudEtudiant GetNext() 
        {
            return next;
        }

        public NoeudEtudiant GetPrevious()
        {
            return previous;
        }

       //Setters
       public void SetData(Etudiant data)
            {
            this.data = data;
        }

        public void SetNext(NoeudEtudiant next)
        {
            this.next = next;
        }

        public void SetPrevious(NoeudEtudiant previous)
        {
            this.previous = previous;
        }


    }
}
