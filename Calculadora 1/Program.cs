using System;

namespace Calculadora_1
{
    class Program
    {
        static int n1 = 0, n2 = 0;

        static void Main(string[] args)
        {
            int op;
            bool ejecutar = true;
            Console.WriteLine("<< CALCULADORA >>");
            Console.WriteLine("----------------------");
            do
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("----------------------");
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplicacion");
                Console.WriteLine("5 - Apagar calculadora");
                Console.WriteLine("-----------------------");
                op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.WriteLine("<< SUMA >>");
                        Console.WriteLine("Introduzca el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La suma de los numeros es: " + (n1 + n2));

                        break;
                    case 2:
                        Console.WriteLine("<< RESTA >>");
                        Console.WriteLine("Introduzca el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La resta de los numeros es: " + (n1 - n2));

                        break;
                    case 3:
                        Console.WriteLine("<< DIVISION >>");
                        Console.WriteLine("Introduzca el primer numero: ");
                        double nm1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        double nm2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La division de los numeros es: " + ((double)nm1 / (double)nm2));

                        break;
                    case 4:
                        Console.WriteLine("<< MULTIPLICACION >>");
                        Console.WriteLine("Introduzca el primer numero: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo numero: ");
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("La multiplicacion de los numeros es: " + (n1 * n2));

                        break;
                    case 5:
                        ejecutar = false;
                        break;

                    default:
                        Console.WriteLine("Intentelo de nuevo");
                        Console.ReadLine();
                        break;
                }


            } while (ejecutar);
            Console.WriteLine("Turning off calculator");
        }
    }
}
