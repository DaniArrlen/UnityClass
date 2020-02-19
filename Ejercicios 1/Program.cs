using System;

namespace Ejercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Comparativa de números");
            //Console.WriteLine("Escriba primer número:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escriba segundo número:");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 == num2)
            //{
            //    Console.WriteLine("Los números son iguales.");
            //}
            //else
            //{
            //    Console.WriteLine("Los números no son iguales.");

            //    if (num1 < num2)
            //    {
            //        Console.WriteLine("El segundo número es mayor.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El primer número es mayor.");
            //    }
            //}

            //Console.WriteLine("Pares o Nones");
            //Console.WriteLine("Escriba un número:");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("El número es par.");
            //}
            //else
            //{
            //    Console.WriteLine("El número es impar.");
            //}

            //Console.WriteLine("Multiplos");
            //Console.WriteLine("Escriba primer número:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escriba segundo número:");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 % num2 == 0)
            //{
            //    Console.WriteLine("Los números son multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Los números no son multiplos");
            //}

            //Console.WriteLine("Negativos o Positivos");
            //Console.WriteLine("Escriba número:");
            //int num = int.Parse(Console.ReadLine());
            //if (num == 0)
            //{
            //    Console.WriteLine("El número es cero");
            //}
            //else
            //{   if (num > 0)
            //    {
            //        Console.WriteLine("El número es positivo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número es negativo");
            //    }
            //}

            //Console.WriteLine("1 para Refran");
            //Console.WriteLine("2 para Chiste");
            //Console.WriteLine("3 para Piropo");
            //Console.WriteLine("Introduzca número:");
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("A quien madruga Dios le ayuda.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Van dos en la moto y se cae el de en medio.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Que te follen.");
            //        break;
            //    default:
            //        Console.WriteLine("Número Erroneo");
            //        break;
            //}

            //Console.WriteLine("NOTAS");
            //Console.WriteLine("Introduzca sus notas");
            //Console.Write("Introduzca la primera nota: ");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.Write("Introduzca la segunda nota: ");
            //float num2 = float.Parse(Console.ReadLine());
            //Console.Write("Introduzca la tercera nota: ");
            //float num3 = float.Parse(Console.ReadLine());
            //if ((num1 < 0 || num2 < 0 || num3 < 0) || (num1 > 10 || num2 > 10 || num3 > 10))
            //{
            //    Console.WriteLine("Valor Erroneo. Introduzca un valor entre 0 y 10");
            //}
            //else
            //{
            //    Console.Write("Su nota media es: " + ((num1 + num2 + num3) / 3f));
            //}

            Console.WriteLine("ALTURA");
            Console.WriteLine("Dime tu altura en centimetros: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 175)
            {
                Console.WriteLine("Eres un gigante.");
            }
            else
            {
                if (num >= 140 && num <= 175)
                {
                    Console.WriteLine("Eres normalito");
                }
                else
                {
                    if (num >= 0 && num <= 140)
                    {
                        Console.WriteLine("Eres un enano");
                    }
                    else
                    {
                        Console.WriteLine("¿Eres microscopico o qué?");
                    }
                }
            }
        }
    }
}
