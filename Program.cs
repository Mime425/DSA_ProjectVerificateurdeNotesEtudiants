namespace DSA_Projet_VérificateurDeNotesÉtudiants;

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
            Console.WriteLine("4. Mettre à jours les notes");
            Console.WriteLine("5. Supprimer un étudiant");
            Console.WriteLine("4. Trier les étudiants par ID");
            Console.WriteLine("5. Trouver et afficher la note minimale et maximale");
            Console.WriteLine("6. Quitter");
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

                        Console.Write("Entrez le nom de cours: ");
                        e.SetMatiere(Console.ReadLine());

                        Console.Write("Entrez la note 1 de l'étudiant: ");
                        e.SetNote1(double.Parse(Console.ReadLine()));

                        Console.Write("Entrez la note 2 de l'étudiant: ");
                        e.SetNote2(double.Parse(Console.ReadLine()));

                        Console.Write("Entrez la note 3 de l'étudiant: ");
                        e.SetNote3(double.Parse(Console.ReadLine()));

                        Console.Write("Entrez la pondération de la note 1: ");
                        double p1 = double.Parse(Console.ReadLine());

                        Console.Write("Entrez la pondération de la note 2: ");
                        double p2 = double.Parse(Console.ReadLine());

                        Console.Write("Entrez la pondération de la note 3: ");
                        double p3 = double.Parse(Console.ReadLine());
                        e.setPonderation(p1, p2, p3); // setter pour les pondérations


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
                            Etudiant eCase3 = gestion.getEtudiantById(id);


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
                    // Mettre à jour les notes
                    try
                    {
                        Console.WriteLine("Entrez l'ID de l'étudiant pour porter une modification: ");
                        int id = int.Parse(Console.ReadLine());
                        Etudiant e = gestion.getEtudiantById(id);

                        if (e != null)
                        {
                            Console.WriteLine("Entrez la nouvelle note1 :");
                            e.SetNote1(double.Parse(Console.ReadLine()));
                            Console.WriteLine("Entrez la nouvelle note2 :");
                            e.SetNote1(double.Parse(Console.ReadLine()));
                            Console.WriteLine("Entrez la nouvelle note3 :");
                            e.SetNote1(double.Parse(Console.ReadLine()));

                            e.CalculNoteFinal();
                            Console.WriteLine("Les notes ont été modifiées");
                        }
                        else
                        {
                            Console.WriteLine("L'étudiant n'est pas trouvé");
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("Entrée invalide");
                    }
                        break;
                        

                    case "5":
                    try //supprimer un étudiant
                    {
                        Console.WriteLine("Entrez le ID de l'étudiant que vous voulez supprimer: ");
                        int id = int.Parse(Console.ReadLine());

                        gestion.supprimerEtudiant(id);
                    }
                    catch 
                    {
                        Console.WriteLine("Le ID d'étudiant n'est pas valid");
                    } 
                    break;

                    case "6":
                    // Code pour trouver et afficher la note minimale et maximale
                    try
                    {
                        double[] result = gestion.FindMinMax();

                        Console.WriteLine("Note minimale est: " + result[0]);
                        Console.WriteLine("Note minimale est: " + result[1]);

                    }
                    catch
                    {
                        Console.WriteLine("On ne peut pas calculer le minimum et maximum");
                    }
                    break;

                case "7":  //afficher les statistiques
                    try
                    {
                        Console.WriteLine("Moyenne de la classe" + gestion.CalculMoyenneClasse());
                    }
                    catch
                    {
                        Console.WriteLine("Ne peux pas afficher les statistiques");
                    }
                    break;


                case "8":
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
