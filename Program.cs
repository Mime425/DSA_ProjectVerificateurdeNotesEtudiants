namespace DSA_Projet_VérificateurDeNotesÉtudiants
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GestionEtudiants gestion = new GestionEtudiants();
            bool quitter = false;

            while (!quitter)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Afficher les étudiants");
                Console.WriteLine("3. Rechercher un étudiant par ID");
                Console.WriteLine("4. Mettre à jour les notes");
                Console.WriteLine("5. Supprimer un étudiant");
                Console.WriteLine("6. Trouver et afficher la note minimale et maximale");
                Console.WriteLine("7. Afficher les statistiques");
                Console.WriteLine("8. Quitter");
                Console.Write("Choisissez une option: ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        // Code pour ajouter un étudiant
                        // Main faire le création de l'étudiant à partir de l'input des entrées 
                        // et envoi à la classe gestion.
                        try
                        {
                            Etudiant e = new Etudiant();
                            Console.Write("Entrez l'ID de l'étudiant: ");
                            e.SetId(int.Parse(Console.ReadLine()));
                            Console.Write("Entrez le prénom de l'étudiant: ");
                            e.SetPrenom(Console.ReadLine());
                            Console.Write("Entrez le nom de l'étudiant: ");
                            e.SetNom(Console.ReadLine());
                            Console.Write("Entrez la note 1 de l'étudiant: ");
                            e.SetNoteMath(double.Parse(Console.ReadLine()));
                            Console.Write("Entrez la note 2 de l'étudiant: ");
                            e.SetNoteFrancais(double.Parse(Console.ReadLine()));
                            Console.Write("Entrez la note 3 de l'étudiant: ");
                            e.SetAnglais(double.Parse(Console.ReadLine()));
                            e.CalculNoteFinal();
                            gestion.ajouterEtudiant(e);
                            Console.WriteLine("Étudiant ajouté avec succès.");
                        }
                        catch
                        {
                            Console.WriteLine("Entrée invalide. Veuillez réessayer.");
                        }

                        break;

                    case "2":
                        gestion.afficherEtudiants();
                        break;

                    case "3":
                        // Code pour rechercher un étudiant par ID
                        try
                        {
                            Console.Write("Entrez l'ID de l'étudiant à rechercher: ");
                            int id = int.Parse(Console.ReadLine());
                            Etudiant eCase3 = gestion.LinearSearchID(id);


                            if (eCase3 != null)
                            {
                                Console.WriteLine($"Étudiant trouvé: {eCase3.getPrenom()} {eCase3.getNom()}");
                            }
                            else
                            {
                                Console.WriteLine("Étudiant non trouvé.");
                            }
                        }
                        // catch (quelque chose qui interceptera si le user entrer quelque chose invalide pour l'ID)
                        catch
                        {
                            Console.WriteLine("ID invalide. Veuillez entrer un nombre entier.");
                        }

                        break;

                    case "4":
                        // Code pour trier les étudiants par ID
                        gestion.QuickSortByID();
                        Console.WriteLine("Étudiants triés par ID.");
                        break;

                    case "5":
                        // Code pour trouver et afficher la note minimale et maximale
                        //pas fini
                        break;

                    case "6":
                        quitter = true;
                        Console.WriteLine("Quitter le programme. Au revoir!");
                        break;

                    default:
                        Console.WriteLine("Option invalide, veuillez réessayer.");
                        break;
                }
            }
        }

    }
}
