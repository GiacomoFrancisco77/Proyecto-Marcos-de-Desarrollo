using Calculadora;
using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        double num1, num2;
        var op = new Class1();

        do
        {
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("1.Suma  2.Resta  3.Multiplicación  4.Division  0.Salir");
            opcion = int.Parse(Console.ReadLine());

            if (opcion!=0)
            {
                if (opcion>=1 && opcion<=4)
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());


                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + op.Suma(num1,num2));
                            break;
                        case 2:
                            Console.WriteLine("La resta de " + num1 + " y " + num2 + " es: " + op.Resta(num1,num2));
                            break;
                        case 3:
                            Console.WriteLine("La multiplicación de " + num1 + " y " + num2 + " es: " + op.Multiplicacion(num1,num2));
                            break;
                        case 4:
                            Console.WriteLine("La división será: " + num1 + "/" + num2);
                            if (num2 != 0)
                            { 
                                Console.WriteLine("La división de " + num1 + " y " + num2 + " es: " + op.Division(num1,num2));
                            }
                            else
                            {
                                Console.WriteLine("El denominador debe ser mayor que 0");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("La opción debe estar entre 1 y 4 o 0 para salir");
                }
            }
        } while (opcion != 0);
    }
}