using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre(int min, int max, int chance) {

            string reponse = "";
            int nombreUtilisateur = min - 1;
            

            while((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.Write($"Entrez un nombre entre {min} et {max} : ");
                reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);
                    if((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine($"Erreur, vous devez entrer un chiffre entre {min} et {max}");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez rentrer un nombre");
                }
            }
            return nombreUtilisateur;
        }
        
        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_ESSAI = 5;

            Random rand = new Random();

            int nombreMagique = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MIN - 1;
            int nbVie = NB_ESSAI;

            

            while ((nombre != nombreMagique) && (nbVie > 0))
            {
                Console.WriteLine();
                Console.WriteLine($"Vous avez {nbVie} chances pour trouver le nombre magique");
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX, NB_ESSAI);

                if (nombre < nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else if (nombre > nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                }
                nbVie--;
                if((nbVie >= 1) && (nombre != nombreMagique))
                {
                    Console.WriteLine($"Il vous reste {nbVie} chance(s)");
                }
                else if((nbVie == 0) && (nombre != nombreMagique))
                {
                    Console.WriteLine($"Le nombre magique était : {nombreMagique}, Vous avez perdu !!!");
                }
                
            }
            

        }
    }
}
