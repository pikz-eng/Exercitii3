using System.Reflection.PortableExecutable;

namespace Exercitii3;

class Program
{

     static void Main(string[] args)
     {
         /**//* *//*. Gigel are un cos cu bile  de 3  culori diferite : rosii, verzi si galbene,
           insa aceste se gandeste cum ar putea sa le grupeze invers dupa culori astfel incat sa obttina in cosul lui urmatoarea
           ordine : galbene, verzi si rosii, 
           realizati un program ce il poate ajuta pe Gigel sa ordoneze eficient aceste bile din cos.*//**/


         string[] bile = { "rosii", "verzi", "galbene" };

         SortareBile(bile, bile.Length - 1);

     }

    static void SortareBile(string[] bile, int index)
    {
        //fara recurisivitate
        for (int i = bile.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(bile[i]);
        }


        //cu recursivitate
        if (index >= 0)
        {
            Console.Write(bile[index]);
            SortareBile(bile, index - 1);
        }



        static void Main(string[] args)
        {
            /*. Marius are un cos cu fructe : banane, 
             portocale si mere. Merele sunt numerotate cu  m a cate 4,
             portocale p a cate 7 si banane b a cate 8.
        Ajutal pe Marius sa isi determine algoritmul prin care ar putea sa ordoneze fructele in functie de numarul cantitatii indicate.
        */
            int mere = 9;
            int portocale = 10;
            int banane = 2;

            string[] fructe = { "portocale", "mere", "banane" };
            int[] cantitateFructe = { mere, portocale, banane };

            SortareFructeDupaCantitate(fructe, cantitateFructe);
            PrintareVector(fructe);
        }

        static void SortareFructeDupaCantitate(string[] fructe, int[] cantitateFructe)
        {
            for (int i = 0; i < fructe.Length - 1; i++)
            {
                for (int j = i + 1; j < fructe.Length; j++)
                {
                    if (cantitateFructe[i] > cantitateFructe[j])
                    {
                        int auxCantitate = cantitateFructe[i];
                        cantitateFructe[i] = cantitateFructe[j];
                        cantitateFructe[j] = auxCantitate;

                        string auxFructe = fructe[i];
                        fructe[i] = fructe[j];
                        fructe[j] = auxFructe;

                    }
                }
            }
            for (int i = 0; i < cantitateFructe.Length; i++)
            {
                Console.Write($"{fructe[i]}: {cantitateFructe[i]}");
            }
        }
        static void PrintareVector(string[] fructe)
        {


            for (int i = 0; i < fructe.Length; i++)
            {
                Console.Write(fructe[i] + " ");
            }


            /*Gigel afla de la prietenul sau cel mai bun Marius, ca in zona Peninsulei 
             * Resort exista niste suveniruri pretioase depozitate in fuctie de o pozitie unica pe diferite rafturi
             ceea ce acasta ocazie ii poate deschide usa catre imbogatire. Acesta se gandeste ca daca ar colecta
        cate un suvenir specific pozitiei ar ajunge  posibil la n suveniruri colectate astfel ajugand la dependenta finananciara.
            Ajutal pe Gigel sa realizeze un program ce va fi capabil sa faca suma tuturot suvenirilor colectate de pe fiecare pozitie in parte.*
        */
            static void Main(string[] args)
            {
                string[] suvenir = { "cutie", "brelog", "cercei" };
                PrintareSuvenir(suvenir);
                int suma = SumaSuvenir(suvenir, 0);
                Console.Write("suma = " + suma);
            }

            static int SumaSuvenir(string[] suvenir, int index)
            {
                //recursiva
                if (index == suvenir.Length)
                {
                    return 0;
                }

                int suma = index + SumaSuvenir(suvenir, index + 1);
                return suma;



                //aici fara recursivitate
                int sum = 0;
                for (int i = 0; i < suvenir.Length; i++)
                {
                    sum += i;
                }

                Console.WriteLine("suma positiilor = " + sum);
            }


            static void PrintareSuvenir(string[] suvenir)
            {
                for (int i = 0; i < suvenir.Length; i++)
                {
                    Console.Write(suvenir[i] + " ");
                    Console.WriteLine(i);
                }
            }
        }
    }