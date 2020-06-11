using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace quicksort
{
    class Class
    {
        static void Main()
        {

            int n;
            Console.Write("Ingrese la cantidad de numeros: ");
            n = Int32.Parse(Console.ReadLine());
            llenar b = new llenar(n);
        }
    }

    class llenar
    {
        int h;
        int[] vector;
        Random rnd = new Random();
        public llenar(int n)
        {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++)
            {
                vector[i] = rnd.Next(0,10000);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            quicksort(vector, 0, h - 1);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            //mostrar();
            Console.ReadKey();
        }

        private void quicksort(int[] vector, int primero, int ultimo)
        {


            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                {
                    while (vector[j] > pivote) j--;
                    if (i <= j)
                    {
                        int temp;
                        temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                        i++;
                        j--;
                    }
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
            

        }

        private void mostrar()
        {
            Console.WriteLine("Ahora se muestra el vector acomodadito (creo)");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadLine();
        }
    }
}