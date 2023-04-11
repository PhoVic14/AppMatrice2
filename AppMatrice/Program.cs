using System;

namespace AppMatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            methodes MesOutils = new methodes();
            bool continuer = true;
            while (continuer)
            {
                int choix = 0;
                while (choix < 1 || choix > 3)
                {
                    Console.WriteLine("Que voulez-vous faire ?");
                    Console.WriteLine("1. Générer un tableau aléatoire");
                    Console.WriteLine("2. Additionner deux matrices");
                    Console.WriteLine("3. Multiplier deux matrices");

                    choix = int.Parse(Console.ReadLine());

                    if (choix < 1 || choix > 3)
                    {
                        Console.WriteLine("Choix invalide");
                    }
                }

                if (choix == 1)//Generer tableau aléatoire
                {
                    int nbLigne, nbColonne;
                    Console.WriteLine("Saisissez le nombre de lignes du tableau :");
                    bool nombre = int.TryParse(Console.ReadLine(), out nbLigne);
                    Console.WriteLine("Saisissez le nombre de colonnes du tableau :");
                    bool nombre2 = int.TryParse(Console.ReadLine(), out nbColonne);

                    if (!nombre || !nombre2 || nbLigne <= 0 || nbColonne <= 0)
                    {
                        Console.WriteLine("Veuillez saisir des nombres positifs");
                        continue;
                    }

                    int[,] tableauAlea;
                    MesOutils.Generation_Tableau(nbLigne, nbColonne, out tableauAlea);
                    Console.WriteLine("Tableau généré aléatoirement :");
                    string stringTab;
                    MesOutils.String_Tableau(tableauAlea, out stringTab);
                    Console.WriteLine(stringTab);
                }
                else if (choix == 2)//Addition
                {
                    int nbLigne, nbColonne;
                    Console.WriteLine("Saisissez le nombre de lignes des matrices :");
                    bool nombre = int.TryParse(Console.ReadLine(), out nbLigne);
                    Console.WriteLine("Saisissez le nombre de colonnes des matrices :");
                    bool nombre2 = int.TryParse(Console.ReadLine(), out nbColonne);

                    if (!nombre || !nombre2 || nbLigne <= 0 || nbColonne <= 0)
                    {
                        Console.WriteLine("Veuillez saisir des nombres positifs");
                        continue;
                    }

                    int[,] matrice1, matrice2, matriceSum;
                    MesOutils.Generation_Tableau(nbLigne, nbColonne, out matrice1);
                    Console.WriteLine("Matrice 1 générée aléatoirement :");
                    string stringMat1;
                    MesOutils.String_Tableau(matrice1, out stringMat1);
                    Console.WriteLine(stringMat1);

                    MesOutils.Generation_Tableau(nbLigne, nbColonne, out matrice2);
                    Console.WriteLine("Matrice 2 générée aléatoirement :");
                    string stringMat2;
                    MesOutils.String_Tableau(matrice2, out stringMat2);
                    Console.WriteLine(stringMat2);

                    bool addition;
                    MesOutils.Addition_Matrice(matrice1, matrice2, out matriceSum, out addition);
                    if (addition)
                    {
                        Console.WriteLine("Matrice somme :");
                        string stringMatSum;
                        MesOutils.String_Tableau(matriceSum, out stringMatSum);
                        Console.WriteLine(stringMatSum);
                    }
                    else
                    {
                        Console.WriteLine("Impossible d'additionner les matrices car elles n'ont pas la même taille.");
                    }
                }
                else if (choix == 3)//Multiplication
                {
                    int nbLigne1, nbColonne1, nbLigne2, nbColonne2;
                    Console.WriteLine("Saisissez le nombre de lignes de la première matrice :");
                    bool nombre1 = int.TryParse(Console.ReadLine(), out nbLigne1);
                    Console.WriteLine("Saisissez le nombre de colonnes de la première matrice :");
                    bool nombre2 = int.TryParse(Console.ReadLine(), out nbColonne1);

                    Console.WriteLine("Saisissez le nombre de lignes de la deuxième matrice :");
                    bool nombre3 = int.TryParse(Console.ReadLine(), out nbLigne2);
                    Console.WriteLine("Saisissez le nombre de colonnes de la deuxième matrice :");
                    bool nombre4 = int.TryParse(Console.ReadLine(), out nbColonne2);

                    if (!nombre1 || !nombre2 || !nombre3 || !nombre4 || nbLigne1 <= 0 || nbColonne1 <= 0 || nbLigne2 <= 0 || nbColonne2 <= 0 || nbColonne1 != nbLigne2)
                    {
                        Console.WriteLine("Veuillez saisir des nombres positifs et des matrices compatibles.");
                        continue;
                    }

                    int[,] matrice1, matrice2, matriceProduct;
                    MesOutils.Generation_Tableau(nbLigne1, nbColonne1, out matrice1);
                    Console.WriteLine("Matrice 1 générée aléatoirement :");
                    string stringMat1;
                    MesOutils.String_Tableau(matrice1, out stringMat1);
                    Console.WriteLine(stringMat1);

                    MesOutils.Generation_Tableau(nbLigne2, nbColonne2, out matrice2);
                    Console.WriteLine("Matrice 2 générée aléatoirement :");
                    string stringMat2;
                    MesOutils.String_Tableau(matrice2, out stringMat2);
                    Console.WriteLine(stringMat2);

                    bool multiplication;
                    MesOutils.Multiplication_Matrice(matrice1, matrice2, out matriceProduct, out multiplication);
                    if (multiplication)
                    {
                        Console.WriteLine("Matrice produit :");
                        string stringMatProduct;
                        MesOutils.String_Tableau(matriceProduct, out stringMatProduct);
                        Console.WriteLine(stringMatProduct);
                    }
                    else
                    {
                        Console.WriteLine("Impossible de multiplier les matrices.");
                    }
                }


                Console.WriteLine("Voulez-vous continuer ? (O/N)");//Boucle de reprise
                string continuerStr = Console.ReadLine();
                continuer = (continuerStr.ToUpper() == "O");
            }
        }

       
    }
}

