using System;

namespace Brick01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Darkness my old friend");

            //EJERCICIO 1
            //Console.Write("Escriba primer número:");
            //int número1 = int.Parse(Console.ReadLine());
            //Console.Write("Escriba segundo número:");
            //int número2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Su suma es:" + (número1 + número2));
            //Console.WriteLine("Su resta es:" + (número1 - número2));
            //Console.WriteLine("Su producto es:" + (número1 * número2));
            //Console.WriteLine("Su division es:" + (número1 / número2));
            //Console.WriteLine("Su porcentaje es:" + (número1 % número2));

            //EJERCICIO 2
            //Console.Write("Escriba su edad:");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 65)
            //{
            //    Console.WriteLine("Estas jubilado.");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad.");
            //}
            //else
            //{
            //    Console.WriteLine("Eres menor de edad.");
            //}


            //bool windy = false;
            //bool sunny = true;
            //bool rainy = true;

            //if(!windy && (rainy || sunny))
            //{
            //    Console.WriteLine("Puedes coger el paraguas");
            //}

            //EJERCICIO 3
            //Console.Write("Introduzca su nota:");
            //int nota = int.Parse(Console.ReadLine());

            //if (nota <= 10 && nota >= 9 )
            //{
            //    Console.WriteLine("Sobresaliente");
            //}
            //else if (nota <= 7 && nota >= 8)
            //{
            //    Console.WriteLine("Notable");
            //}
            //else if (nota >= 6 && nota < 6)
            //{
            //    Console.WriteLine("Bien");
            //}
            //else if (nota >= 5 && nota < 5)
            //{
            //    Console.WriteLine("Suficiente");
            //}
            //else if (nota >= 0 && nota < 5)
            //{
            //    Console.WriteLine("Suspenso");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR 404");
            //}

            //EJERCICIO 4

            Console.Write("Introduzca su nota:");
            int numero = int.Parse(Console.ReadLine());
                switch (numero)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("Sobresaliente");
                        break;
                    case 8:
                    case 7:
                        Console.WriteLine("Notable");
                        break;
                    case 6:
                    case 5:
                        Console.WriteLine("Suficiente");
                        break;
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        Console.WriteLine("Suspenso");
                        break;
                    default:
                        Console.WriteLine("ERROR 404");
                        break;
                }
        }
    }
}