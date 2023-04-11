using System;
using System.Collections.Generic;
using System.Text;

namespace AppMatrice
{
    public struct methodes
    {
        /// <summary>
        /// Generer un tableau
        /// </summary>
        /// <param name="nbLigne">nombre de ligne dans la matrice</param>
        /// <param name="nbColonne">nombre de colonne dans la matrice</param>
        /// <param name="tableau"></param>
        public void Generation_Tableau(int nbLigne, int nbColonne, out int[,] tableau)
        {
            tableau = new int[nbLigne, nbColonne];
            Random random = new Random();
            for (int i = 0; i < nbLigne; i++)
            {
                for (int j = 0; j < nbColonne; j++)
                {
                    tableau[i, j] = random.Next(1, 10);
                }
            }
        }

        /// <summary>
        /// Remplire la matrice
        /// </summary>
        /// <param name="nbLigne">nombre de colonne dans la matrice</param>
        /// <param name="nbColonne">nombre de colonne dans la matrice</param>
        /// <param name="matrice">matrice</param>
        public void Remplir_Matrice(int nbLigne, int nbColonne, out int[,] matrice)
        {
            matrice = new int[nbLigne, nbColonne];
            for (int i = 0; i < nbLigne; i++)
            {
                for (int j = 0; j < nbColonne; j++)
                {
                    Console.WriteLine("Saisissez l'élément à la position [{0}, {1}] :", i, j);
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        /// <summary>
        /// Additioner la matrice
        /// </summary>
        /// <param name="matrice1">matrice numero 1</param>
        /// <param name="matrice2">matrice numero 2</param>
        /// <param name="matriceSum"></param>
        /// <param name="addition">addition de la matrice</param>
        public void Addition_Matrice(int[,] matrice1, int[,] matrice2, out int[,] matriceSum, out bool addition)
        {
            int nbLignes = matrice1.GetLength(0);
            int nbColonnes = matrice1.GetLength(1);
            matriceSum = new int[nbLignes, nbColonnes];
            addition = true;

            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    matriceSum[i, j] = matrice1[i, j] + matrice2[i, j];
                }
            }
        }

        /// <summary>
        /// Multiplier la matrice
        /// </summary>
        /// <param name="matrice1">matrice numero 1</param>
        /// <param name="matrice2">matrice numero 2</param>
        /// <param name="matriceProduct"></param>
        /// <param name="multiplication">multipication</param>
        public void Multiplication_Matrice(int[,] matrice1, int[,] matrice2, out int[,] matriceProduct, out bool multiplication)
        {
            int nbLignes1 = matrice1.GetLength(0);
            int nbColonnes1 = matrice1.GetLength(1);
            int nbLignes2 = matrice2.GetLength(0);
            int nbColonnes2 = matrice2.GetLength(1);
            matriceProduct = new int[nbLignes1, nbColonnes2];
            multiplication = true;

            for (int i = 0; i < nbLignes1; i++)
            {
                for (int j = 0; j < nbColonnes2; j++)
                {
                    matriceProduct[i, j] = 0;
                    for (int k = 0; k < nbColonnes1; k++)
                    {
                        matriceProduct[i, j] += matrice1[i, k] * matrice2[k, j];
                    }
                }
            }
        }

        /// <summary>
        /// Mettre le tableau en string
        /// </summary>
        /// <param name="tableau"></param>
        /// <param name="stringTableau"></param>
        public void String_Tableau(int[,] tableau, out string stringTableau)
        {
            int nbLignes = tableau.GetLength(0);
            int nbColonnes = tableau.GetLength(1);
            stringTableau = "";

            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    stringTableau += tableau[i, j].ToString() + "\t";
                }
                stringTableau += "\n";
            }
        }
    }
}
