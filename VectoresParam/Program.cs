using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{
    class PruebaVector
    {
        private int[,] MatrizA;
        private int[,] MatrizB;
        private int[,] MatrizC;

        public void Cargar()
        {
            MatrizA = new int[10, 10];
            MatrizB = new int[10, 10];
            MatrizC = new int[10, 10];

            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizA[i, j] = int.Parse(linea);
                }
            }

            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizB[i, j] = int.Parse(linea);
                }
            }


            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] * MatrizB[i, j];
                }
            }
        }

        public void visualizar()
        {
            Console.WriteLine("La suma de la MatrizA y MatrizB es :");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.visualizar();
        }
    }
}