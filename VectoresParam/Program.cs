using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        private int[,] mat;

        const int MAX = 10;
        static void Main(string[] args)
        {

            Program ma = new Program();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();

            int[] x = new int[MAX];
            string[] nombres = new string[MAX];

            leer(x);
            imprimir(x);
            
            ordenar(x);
            Console.WriteLine("vector ordenar");
            imprimir(x);
            if (buscar(x, 15))
                Console.WriteLine("\n15 encontrado");
            else
                Console.WriteLine("\n15 NO EXISTE ");
            Console.ReadKey();
          
            if (buscar(x, 25))
                Console.WriteLine("\n25 encontrado");
            else
                Console.WriteLine("\n25 NO EXISTE ");
            Console.ReadKey();

            Console.Clear();

            //trabajo con el vector de cadenas de caracter
            Console.WriteLine("\n ingrese los nombres");
            leerNombres(nombres);
            imprimirNombres(nombres);
            ordenarNombres(nombres);
            Console.ReadKey();

        }


        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }




































        public static void leer(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngresa del elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());


            }



        }

        //Agregar el metodo que recibe como parametro un entero y devuelve (V) y si estae entero existe en el vector; devuelve (f) si no existe //
        public static void imprimir(int[] x)
        {
            foreach (int num in x)
            {
                Console.WriteLine("\nlememto {0}", num);
            }
        }

        public static bool buscar(int[] x, int y)
        {
            bool encontrado = false;
            foreach (int num in x)
            {
                if (num == y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;

        }
        public static bool buscar2(int[] x, int y)
        {
               bool encontrado = false;
                int i = 0;
                while (i < MAX && encontrado == false)
                { 
                    if (x[i] == y)
                        encontrado = true;
                    i++;
                }
                return encontrado;                                 
           

        }
        //CLASE//
        public static void ordenar(int[]x )
        {
            int aux = 0;
            for (int i = 0; i <x.Length; i++)
                for (int j = i + 1; j < (x.Length); j++)
                    if (x[i] > x[j]) 
                    {//Ingrese el elmento
                        aux = x[i];
                        x[i]= x[j];
                        x[j] = aux;
                    }
        }

        public static void leerNombres(string[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngresa del elemento {0}", i + 1);
                x[i] = (Console.ReadLine());


            }

        }
        public static void imprimirNombres(string[] x)
        {
            foreach (string  num in x)
            {
                Console.WriteLine("\nlememto {0}", num);
            }
        }

        public static void ordenarNombres(string[] x)
        {
            string aux = "";
            for (int i = 0; i < x.Length; i++)
                for (int k = i + 1; k < x.Length; k++)
                    if (String.Compare(x[i], x[k], StringComparison.Ordinal) > 0)
                    { 
                        aux = x[i];
                        x[i] = x[k];
                        x[k] = aux;
                    }


        }
    }
   
}


