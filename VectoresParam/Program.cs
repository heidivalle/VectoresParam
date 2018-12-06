using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            leer(x);
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
    

    }
   
}


