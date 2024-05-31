using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_suma_resta_y_areas
{
    internal class ProgramaCalculos  //clase
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Potencia");
                Console.WriteLine("5 - Área del Triángulo");
                Console.WriteLine("6 - Área del Cuadrado");
                Console.WriteLine("7 - Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                    
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Dividir();
                        break;
                    case 4:
                        Potencia();
                        break;
                    case 5:
                        AreaTriangulo();
                        break;
                    case 6:
                        AreaCuadrado();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 7);

        }
        //metodos
        public static void Sumar()
            { 
            Console.WriteLine("Ingrese el primer número a sumar: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 + num2));
        }

        public static void Restar()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 - num2));
            
        }

        public static void Dividir()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (num1 / num2));

        }

        public static void Potencia()
        {
            Console.WriteLine("Ingrese la base: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + Math.Pow(num1, num2));
            
        }

        public static void AreaTriangulo()
        {
            Console.WriteLine("Ingrese la base del triángulo: ");
            double BaseTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double AlturaTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + (BaseTriangulo * AlturaTriangulo) / 2);

        }

        public static void AreaCuadrado()
        {
            Console.WriteLine("Ingrese el lado: ");
            double LadoCuadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + Math.Pow(LadoCuadrado, 2));

        }
    }

    
}
