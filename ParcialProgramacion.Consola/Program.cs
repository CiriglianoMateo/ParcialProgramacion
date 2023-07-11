
using System;

namespace ParcialProgramacion.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado, altura, area, arista, volumen;
            int cantidadPiramides = 0;
            bool seguir = true;

            do
            {
                Console.WriteLine("Ingresar el valor de la altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el valor del lado de la base: ");
                lado = Convert.ToDouble(Console.ReadLine());


                if (lado == 0 && altura == 0)
                {
                    Console.WriteLine("Valores no permitidos");
                    seguir = false;
                }
                else
                {
                    area = CalcularArea(altura, lado);
                    arista = CalcularArista(altura, lado);
                    volumen = CalcularVolumen(altura, lado);

                    Console.WriteLine("Área: " + area);
                    Console.WriteLine("Arista: " + arista);
                    Console.WriteLine("Volumen: " + volumen);

                    cantidadPiramides++;
                }
            } while (seguir);

            Console.WriteLine($"Cantidad de pirámides ingresadas: {cantidadPiramides}");
        }

        private static double CalcularVolumen(double altura, double lado)
        {
            return (Math.Pow(lado, 2) * altura) / 3;
        }

        private static double CalcularArista(double altura, double lado)
        {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(lado, 2)) / 2;
        }

        private static double CalcularArea(double altura, double lado)
        {
            return lado * (lado + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(lado, 2)));
        }
    }
}

