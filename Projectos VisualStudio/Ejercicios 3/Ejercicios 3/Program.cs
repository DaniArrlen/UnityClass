using System;

namespace Ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int counter = 0;
            //while (counter < reps)
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;
            //}

            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter = counter + 1;
            //}
            //while (counter < reps);

            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //for (int counterF = 0; counterF <= reps; counterF++)
            //{
            //    Console.WriteLine(counterF);
            //}

            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int sumaT = 0;
            //int counterF = 1;
            //while (counterF <= reps)
            //{
            //    sumaT = sumaT + counterF;
            //    counterF++;
            //}
            //Console.WriteLine(sumaT);

            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int counterF;
            //int sumaT ;
            //for (counterF = 1, sumaT = 0; counterF <= reps; counterF++)
            //{
            //    sumaT = sumaT + counterF;
            //}
            //Console.WriteLine(sumaT);

            //Console.Write("Introduzca número de repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //for (int counterF = reps; counterF >= 0; counterF--)
            //{
            //    Console.WriteLine(counterF);
            //}

            //Console.WriteLine("1 para Refran");
            //Console.WriteLine("2 para Chiste");
            //Console.WriteLine("3 para Piropo");
            //Console.WriteLine("4 para Salir");
            //Console.WriteLine("Introduzca número:");
            //int num = 0;
            //do
            //{
            //    num = int.Parse(Console.ReadLine());
            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("A quien madruga Dios le ayuda.");
            //            break;
            //        case 2:
            //            Console.WriteLine("Van dos en la moto y se cae el de en medio.");
            //            break;
            //        case 3:
            //            Console.WriteLine("Que te follen.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Adios.");
            //            break;
            //        default:
            //            Console.WriteLine("Número Erroneo");
            //            break;
            //    }
            //}
            //while (num != 4);

            //Console.WriteLine("¿Cuantos números quieres sumar?");
            //int reps = int.Parse(Console.ReadLine());
            //int suma = 0;

            //for (int counter = 0; counter < reps; counter++)
            //{
            //    Console.WriteLine("Introduce número: ");
            //    int num = int.Parse(Console.ReadLine());
            //    suma = suma + num;
            //}
            //Console.WriteLine("La suma es " + suma);

            //Console.WriteLine("¿Cuantos números quieres sumar?");
            //int reps = int.Parse(Console.ReadLine());
            //int[] numbers = new int[reps];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Número " + (i + 1) + ": ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine("El resultado es " + total);
            Console.WriteLine("¿Cuantos números vas a añadir?");
            int reps = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[reps];
            Console.WriteLine("Introduce tu array:");
            for (int i = 0; i < numbers1.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers1[i] = x;
            }
            Console.WriteLine("Nueva array:");
            int[] numbers2 = new int[numbers1.Length]
;           for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = numbers1[i];
                Console.WriteLine(numbers2[i]);
            }
        }
    }
}
