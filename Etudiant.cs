using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    //les attributs
    public class Etudiant
    {
        private int id;
        private string prenom;
        private string nom;
        private double noteMath;
        private double noteFrancais;
        private double noteAnglais;
        private double noteFinal;

        public Etudiant()
        {
            id = 0;
            prenom = "";
            nom = "";
            noteMath = 0;
            noteFrancais = 0;
            noteAnglais = 0;
            noteFinal = 0;

        }

        public Etudiant(int id, string prenom, string nom, double noteMath, double noteFrancais, double noteAnglais, double noteFinal)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.noteMath = noteMath;
            this.noteFrancais = noteFrancais;
            this.noteAnglais = noteAnglais;
            this.noteFinal = noteFinal;
        }

        public int GetId()
        {
            return id;
        }
        public string getPrenom()
        {
            return prenom;
        }
        public string getNom()
        {
            return nom;
        }

        public double getNoteMath()
        {
            return noteMath;
        }
        public double getNoteFrancais() 
        {
            return noteFrancais;
        }
        public double getAnglais() 
        {
            return noteAnglais;
        }

      

        //Setters
        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetFirstName(string firstName)
        {
            this.prenom = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.nom = lastName;
        }

        public void SetNoteMath(double noteMath)
        {
            if (noteMath >= 0 && noteMath <= 100)
            {
                this.noteMath = noteMath;
            }
        }

        public void SetNoteFrancais(double noteFrancais)
        {
            if (noteFrancais >= 0 && noteFrancais <= 100)
            {
                this.noteFrancais = noteFrancais;
            }
        }

        public void SetNoteAnglais(double noteAnglais)
        {
            if (noteAnglais >= 0 && noteAnglais <= 100)
            {
                this.noteAnglais = noteAnglais;
            }
        }

        //calcul note final
        public void CalculNoteFinal()
        {
            noteFinal = (noteMath + noteFrancais + noteAnglais) / 3.0;

        }

        // Override à toString
        public override string ToString()
        {
            return "id: " + id + " Prenom: " + prenom + " Note 1: " + noteMath  + " Note 2: " + noteFrancais +
                   " Note 3: " + noteAnglais +
                   " Note final: " + noteFinal;
        }
    }
}
