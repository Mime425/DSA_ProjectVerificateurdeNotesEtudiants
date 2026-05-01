using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projet_VérificateurDeNotesÉtudiants;

    //les attributs
    public class Etudiant
    {
        private int id;
        private string prenom;
        private string nom;
        private double noteMath;
        private double noteFrancais;
        private double noteAnglais;
        private string matiere;
        private double note1;
        private double note2;
        private double note3;
        private double noteFinal;

    public Etudiant()
    {
        id = 0;
        prenom = "";
        nom = "";
        matiere = "";
        note1 = 0;
        note2 = 0;
        note3 = 0;
        noteFinal = 0;
    }

    public Etudiant(int id, string prenom, string nom, string matiere, double note1, double note2, double note3, double noteFinal)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.matiere = matiere;
            this.note1 = note1;
            this.note2 = note2;
            this.note3 = note3;
            this.noteFinal = noteFinal;
        }

    //Getters

        public int getId()
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

        public string getMatiere()
        {
            return matiere;
        }

        public double getNote1() 
        {
            return note1;
        }
        public double getNote2() 
        {
            return note2;
        }
    public double getNote3()
    {
        return note3;
    }

    public double getNoteFinal()
        { 
            return noteFinal; 
        }


    //Setters
    public void SetId(int id)
    {
        if (id >= 0)
        {
            this.id = id;
        }
    }

    public void SetPrenom(string prenom)
    {
        this.prenom = prenom;
    }

    public void SetNom(string nom)
    {
        this.nom = nom;
    }

    public void SetMatiere(string matiere)
    {
        this.matiere = matiere;
    }

    public void SetNote1(double note1)
    {
        if (note1 >= 0 && note1 <= 100)
        {
            this.note1 = note1;
        }
    }

    public void SetNote2(double note2)
    {
        if (note2 >= 0 && note2 <= 100)
        {
            this.note2 = note2;
        }
    }

    public void SetNote3(double note3)
    {
        if (note3 >= 0 && note3 <= 100)
        {
            this.note3 = note3;
        }
    }

    public void CalculNoteFinal()
    {
        noteFinal = (note1 * 0.2) + (note2 * 0.3) + (note3 * 0.5);
    }

    public override string ToString()
    {
        return "id: " + id + " Prenom: " + prenom + " Nom: " + nom + "Matière:" + matiere +
               " Note 1: " + note1 + " Note 2: " + note2 +
               " Note 3: " + note3 + " Note final: " + noteFinal;
    }
}