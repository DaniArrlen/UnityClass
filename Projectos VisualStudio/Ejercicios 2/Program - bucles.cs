using System;

namespace Ejercicios_2___Bucles
{
    class Ejercicios
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduzca el número de repeticiones:");
            //int rep = int.Parse(Console.ReadLine());
            //int counter = 0;
            //Console.WriteLine("Repeticiones:");
            //while (counter < rep)
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;
            //}

            //Console.WriteLine("TABLAS");
            //Console.Write("Primer número:");
            //int multi1 = int.Parse(Console.ReadLine());
            //Console.Write("Multiplicar por:");
            //int multi2 = int.Parse(Console.ReadLine());
            //int counter = 0;
            //while (counter < multi2)
            //{
            //    Console.WriteLine(multi1 + " x " + counter + "=" + (multi1*counter));
            //    counter++ ;
            //}

            //Console.WriteLine("Introduzca el número de repeticiones:");
            //int rep = int.Parse(Console.ReadLine());
            //int counter = 0;
            //Console.WriteLine("Repeticiones:");
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;
            //}
            //while (counter < rep);

            Console.WriteLine("Introduzca el número de repeticiones:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Repeticiones:");
            for (int i = 0; i < num; i++)
            {    
                Console.WriteLine(i);
            }

            Console.WriteLine("TABLAS (for)");
            Console.Write("Primer número:");
            int multi1 = int.Parse(Console.ReadLine());
            Console.Write("Multiplicar por:");
            int multi2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < multi2; i++)
            {
                Console.WriteLine(multi1 + " x " + i + " = " + (multi1 * i));
            }
        }
    }
}
