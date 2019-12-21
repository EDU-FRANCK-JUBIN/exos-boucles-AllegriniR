using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exos_boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avec une boucle for ");
            for (int i = 0; i < 21; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Avec une boucle while ");
            int cpt = 0;
            while (cpt < 21)
            { 
                Console.WriteLine(cpt);
                cpt += 2;
            }



            Console.WriteLine("Entrez un nombre pour faire la sommes des entiers inférieurs ");
            int nombre = Int32.Parse(Console.ReadLine());
            int total = 0;
            for (int i = nombre; i > 0; i--)
            {
                total += i;
            }
            Console.WriteLine("La somme est de : " + total);
            Console.WriteLine("Saisissez 5 nombres séparés par des espaces ");
            string inputString = Console.ReadLine();
            string[] inputTab = inputString.Split(' ');
            int[] nombresArray = Array.ConvertAll(inputTab, int.Parse);
            List<int> nombres = nombresArray.ToList();

            float somme = 0;
            foreach (float f in nombres)
            {
                somme += f;
            }

            Console.WriteLine("La moyenne  est de " + somme / nombres.Count);
            Console.WriteLine("La moyenne avec Average() est de " + nombres.Average());

            Console.WriteLine("Somme des entiers entre 1 et 10 : " +CalculSommeEntier(1, 10));
            Console.WriteLine("Somme des entiers entre 1 et 100 : " +CalculSommeEntier(1, 100));

            List<float> floats = new List<float> { 1.0F, 5.5F, 9.9F, 2.8F, 9.6F };
            Console.WriteLine("La moyenne  est de " + CalculMoyenne(floats));
            Console.WriteLine("La moyenne avec Average() est de " + CalculMoyenneAvecAverage(floats));

            Console.WriteLine("La somme des entiers compris en 1 et 100 et multiple de 3 et 5 est " + SommeEntiersCommuns());
            Console.ReadKey();
        }

        public static int CalculSommeEntier(int x, int y)
        {
            int somme = 0;
            // si jamais y est plus grand que x, on inverse les 2
            if (x > y)
            {
                int tmp = y;
                y = x;
                x = tmp;
            }
            for (int i = x; i < y+1; i++)
            {
                somme += i;
            }
            return somme;
        }

        public static float CalculMoyenne(List<float> list)
        {
            float somme = 0;
            foreach(float f in list)
            {
                somme += f;
            }
            return somme / list.Count;
        }

        public static float CalculMoyenneAvecAverage(List<float> list)
        {
            return list.Average();
        }

        public static int SommeEntiersCommuns()
        {
            int somme = 0;
            List<int> multiplesDeTrois = new List<int>();
            List<int> multiplesDeCinq = new List<int>();
            for(int i = 0; i < 101; i += 3)
            {
                multiplesDeTrois.Add(i);
            }
            for (int i = 0; i < 101; i += 5)
            {
                multiplesDeCinq.Add(i);
            }

            foreach(int i in multiplesDeTrois)
            {
                if (multiplesDeCinq.Contains(i))
                {
                    Console.WriteLine(i);
                    somme += i*2; // On fait *2 car le nombre est présent dans les deux listes, donc pour 15 par exemple, on additionne 15 de multiplesDeTrois + 15 de multiplesDeCinq
                }
            }

            return somme;
        }
    }
}
