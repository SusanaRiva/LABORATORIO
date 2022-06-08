using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{

    internal class OrdenarArreglo

    {

        static int[] numeros;

        static int longitud = 0;


        static public void funcionOrdenar()
        {
            // Castear a enteros
            int a = 0;
            int b = 0;
            int aInt = a;
            int bInt = b;

            // Al restarlos, se debe obtener un número mayor, menor o igual a 0
            // Con esto ordenamos de manera ascendente
            Console.WriteLine(aInt - bInt);
            numeros = new int[5];
           

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese los valores del arreglo");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numeros);

                int longitud = numero;
                Console.WriteLine("Imprimendo arreglo antes de ordenar\n");
                for (int x = 0; x < longitud; x++)
                {
                    Console.WriteLine("%d ", numeros[x]);
                }
                Array.Sort(numeros);

                Console.WriteLine("\nImprimendo arreglo ya ordenado\n");
                for (int x = 0; x < longitud; x++)
                {
                    Console.WriteLine("%d ", numeros[x]);
                }


            }


        }
    }
}


