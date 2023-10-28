using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercices
    {

        // exercice 3-1 
        static void majorite(int age)
        {
            Console.WriteLine( age >= 18 ? "Vous êtes majeur" : "Vous êtes mineur");
        }

        // exercice 3-2 
        static void valeurAbsolue(int num)
        {
            Console.WriteLine(Math.Abs(num));
        }

        // exercie 3-3 
        static void admissions(int note)
        {
            string status = "";

            if(note <= 8)
            {
                status = "ajourné";
            } 
            else if(note < 10)
            {
                status = "rattrapage";
            }
            else
            {
                status = "admis";
            }

            Console.WriteLine(status);
        }





        // exercice 2-4 
        static void calculMonnaie()
        {
            double userSomme = 0.99;
            int nombrePieces = 0;
            double[] listeMonnaie;
            listeMonnaie = new double[] { 0.5, 0.2, 0.1, 0.05, 0.02, 0.01};
            IDictionary<double, int> detailMonnaie;


            detailMonnaie = new Dictionary<double, int>();
            while (userSomme > 0)
            {
                for(int i = 0; i < listeMonnaie.Length; i ++)
                {
                    if (listeMonnaie[i] <= userSomme)
                    {
                        userSomme -= listeMonnaie[i];
                        userSomme = Math.Round(userSomme, 2);
                        nombrePieces++;

                        // alimentation du dictionnaire contenant les pièces utilisées. 
                        if (detailMonnaie.ContainsKey(listeMonnaie[i]))
                        {
                            // La clé existe, incrémentez la valeur associée
                            detailMonnaie[listeMonnaie[i]]++;
                        }
                        else
                        {
                            // La clé n'existe pas, ajoutez-la avec une valeur initiale
                            detailMonnaie.Add(listeMonnaie[i], 1);
                        }
                        Console.WriteLine("1 pièce de :" + listeMonnaie[i]);
                        Console.WriteLine("Reste :" + userSomme);
                        break;
                    }
                }
            }

            Console.WriteLine("Vosu avez utilisé :");

            foreach( var paire in detailMonnaie)
            {
                Console.WriteLine($"Valeur : {paire.Key} , nombre : {paire.Value}");
            }


        }

        // exercice 2-3 Cartons et camions
        static double calculCartons()
        {
            double camionCapacite = 0;
            double poidsCarton = 0;
            int nombreCarton = 0;

            nombreCarton = (int)Math.Round(camionCapacite / poidsCarton);

            return nombreCarton;


        }


        // exercice 6
        static double calculSurface(double longueur, double largeur )
        {
            return largeur * longueur;
        }


        // exercice 7 
        static void unicode()
        {
            int successeur;

            // initialiser un array méthode 1 -> les array ne sont aps dynamiquqes ici. 
            char[] tableauChar;
            tableauChar = new char[] { '1','2','3', '4', '5'};

            // méthode 2 : 
            char[] tabChar = { '1', '2', '3', '4', '5' };

            // parcours du tab : 
            foreach ( char c in tableauChar ) 
            {
                Console.WriteLine("Unicode :" +  Convert.ToInt32(c));
            }

            // list 
            // IList<int> list = new List<int>();
            // list.Insert(1, 12); // insère le nombre entier 12 à la position 1 
            // list.Add(5); // ajoute un nouvel élément à la fin de la liste 
            // list.RemoveAt(0); // supprimer l'élement se situant à l'index 0. 

            // dictionnaires 
            IDictionary<string, int> myDict = new Dictionary<string, int>();



            // WriteLine vas à la ligne, Write Non. 
            char a = 'a';
            Console.WriteLine("Unicode : " + (int)a); // ou Convert.ToInt32()
            Console.WriteLine("Majuscule : " + char.ToUpper(a));

            // successeur dans la table unicode 
            successeur = (int)a + 1;
            Console.WriteLine("Successeur : " + successeur + ", " + "Lettre :" + (char)successeur);

            // unicode dans un array : 
            
            int[] array2 = { 1, 2, 3, 4, 5, 6 };

            // parcours du tableau est affichage 
            foreach (int i in array2)
            {
                Console.WriteLine("nombre: " + i);
            }



        }

        // exercice 3-1-4 
        static void Assurance(double montantDegats)
        {
            double montantARembourser;
            double franchise;

            // calcul de la franchise
            franchise = montantDegats * 0.1;

            if(franchise >= 4000)
            {
                Console.WriteLine("C'est Mort");
            } else
            {
                montantARembourser = montantDegats - franchise;
                Console.WriteLine("Franchise : " + franchise);
                Console.WriteLine("Montant à vous rembourser : " + montantARembourser);
            }
              
        }

        // exercice 3-1-6 
        static void ValeursDistinctes()
        {
            string v1 = "";
            string v2 = "";

            Console.WriteLine("Entrez valeur 1 :");
            v1 = Console.ReadLine();

            Console.WriteLine("Entrez valeur 2 :");
            v2 = Console.ReadLine();

            Console.WriteLine(v1 == v2 ? "Valeurs identiques" : "Valeurs différentes");
        }

        // exercice 3-1-7
        static void plusPetitValeur()
        {
            string v1 = "";
            string v2 = "";
            string v3 = "";

            Console.WriteLine("Entrez valeur 1 :");
            v1 = Console.ReadLine();


            Console.WriteLine("Entrez valeur 2 :");
            v2 = Console.ReadLine();

            Console.WriteLine("Entrez valeur 3 :");
            v3 = Console.ReadLine();




        }

        // exercice 3-2 matrice 
        static void echiquier()
        {
            string x;
            string y;

            // déclaration d'un tableau à deux dimensions 
            string[,] matrice = new string[8, 8];

            // on boucle sur les X et les Y 
            for (int i = 1; i < matrice.GetLength(0) + 1; i++)
            {
                for (int j = 1; j < matrice.GetLength(1) + 1; j++)
                {
                    // Si somme des index  est paire, alors noire
                    if ((i + j) % 2 == 0)
                    {
                        matrice[i - 1, j - 1] = "noire";
                    }
                    // sinon case blanche 
                    else
                    {
                        matrice[i - 1, j - 1] = "blanche";
                    }
                }
            }

            // input Utilisateur 
            Console.WriteLine("coordonnée x de la case ?");
            x = Console.ReadLine();
            Console.WriteLine("coordonnée y de la case ?");
            y = Console.ReadLine();

            // calcul et sortie, attention, on inver -> [y, x] car x = ligne, y = colonne 
            string value = matrice[Convert.ToInt32(y) - 1, Convert.ToInt32(x) - 1];
            Console.WriteLine("valeur de la case: " + value);
            

            /*for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    string valeur = matrice[i, j];
                    Console.WriteLine($"Ligne {i}, Colonne {j} : {valeur}");
                }
            }
            */


        }




        static void Main(string[] args)
        {
            // double surface = 0;

            // Console.WriteLine("Hello World");

            // surface = calculSurface(5, 7);

            // Console.WriteLine("La surface est de : " +  surface + " m2");

            // unicode();

            // calculMonnaie();

            // majorite(14);

            // valeurAbsolue(-14);

            // admissions(8);

            // Assurance(40000);

            // ValeursDistinctes();

            echiquier();
        }
    }

    
}
