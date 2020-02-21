using System;
using System.Collections.Generic;

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

            //Console.WriteLine("¿Cuantos números vas a añadir?");
            //int reps = int.Parse(Console.ReadLine());
            //int[] numbers1 = new int[reps];
            //Console.WriteLine("Introduce tu array:");
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    numbers1[i] = x;
            //}
            //Console.WriteLine("Nueva array:");
            //int[] numbers2 = new int[numbers1.Length];
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    numbers2[i] = numbers1[i];
            //    Console.WriteLine(numbers2[i]);
            //}

            //int x = 3;
            //int y = 4;
            //Console.WriteLine(x + " & " + y);
            //int aux = y;
            //y = x;
            //x = aux;
            //Console.WriteLine(x + " & " + y);

            //Console.WriteLine("Ordenación de Arrays");
            //int[] numbers = new int[] { 3, 1, 2 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if(numbers[j] < numbers[i])
            //        {
            //            int aux = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = aux;
            //        }
            //    }
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Astericos");
            //Console.Write("Repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //for (int i = 0; i < reps; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Repeticon de valores");
            //int[] numbers = new int[] { 3, 1, 3 };
            //bool dobles = false;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length && !dobles; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            Console.WriteLine("Hay duplicados.");
            //            dobles = true;
            //        }
            //    }
            //}
            //if (!dobles)
            //{
            //    Console.WriteLine("No hay duplicados.");
            //}

            //Console.WriteLine("Mayor y Menor");
            //int[] numbers = new int[] { 3, 1, 2 };
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine("Mayor: " + max + " Menor: " + min);

            //Console.WriteLine("Patron 2");
            //Console.Write("Repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int x = 1;
            //for (int i = 0; i < reps; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(x + " ");
            //        x++;
            //    }
            //    x = 1;
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Patron 2");
            //Console.Write("Repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int x = 1;
            //for (int i = 0; i < reps; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(x + " ");
            //    }
            //    x++;
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Patron 3");
            //Console.Write("Repeticiones: ");
            //int reps = int.Parse(Console.ReadLine());
            //int x = 1;
            //for (int i = 0; i < reps; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(x++ + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Matriz");
            //int[,] tabla = new int[5, 5];
            //Console.Write("Introduzca primer valor: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Introduzca segundo valor: ");
            //int y = int.Parse(Console.ReadLine());
            //for (int i = 0; i < tabla.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabla.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            tabla[i, j] = x;
            //        }
            //        else
            //        {
            //            tabla[i, j] = y;
            //        }
            //        Console.Write(tabla[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(1000);
            //numbers.Remove(1000);
            //numbers.Add(210);
            //numbers.Add(1);
            //numbers.Add(258);


            //List<char> letras = new List<char>();
            //List<float> decimales = new List<float>();
            //List<string> frases = new List<string>();
            //List<double> dobles = new List<double>();
            //List<bool> booleans = new List<bool>();

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(4);
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " es par.");
                }
                else
                {
                    Console.WriteLine(number + " es impar.");
                }
            }
        }
    }
}
