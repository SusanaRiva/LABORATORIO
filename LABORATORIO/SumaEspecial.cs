using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{
    public class SumaEspecial
    {
        

       static public void sumaEspeciales()
        {
            int[] numeros; //valores sin inicializar
            numeros = new int[5];  //5 numeros
            int suma = 0;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---Suma Especial---");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero de la posicion: ", i);
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine( numeros[i]);
            }
            for (int i =0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
                suma = suma * numeros[i];
            }
            Console.WriteLine("La sumatoria final es: "+ suma) ;
        }
    }
}
