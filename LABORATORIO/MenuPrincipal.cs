using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO
{
  public  class MenuPrincipal
    {
        static private SumaEspecial Suma;
        static private OrdenarArreglo ordenar;
        static private Pascal pascal;
        static private Fibonachi fibonachi; 
        public void menuPrincipal()
        {
            {
                int op = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("***** JUEGO DE VECTORES *****");
                    Console.WriteLine("-----------------------------------------");
  
                    Console.WriteLine("\n" +
                        "\n 1. Suma Especial" +
                        "\n 2. Ordenar Arreglos" +
                        "\n 3. Crear Triángulo de Pasca" +
                        "\n 4.Serie de Fibbonacci" +
                        "\n 5. Salir \n"
                         );
                    Console.WriteLine("Digite una opcion: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            SumaEspecial.sumaEspeciales();
                            
                            break;
                        case 2:
                            OrdenarArreglo.funcionOrdenar();
                            break;
                        case 3:
                            Pascal.GenerarTriangulo();

                            break;
                        case 4:
                            Fibonachi.Fibo();


                            break;
                        case 5:
                            Console.WriteLine("Gracias por su preferencia, vuelva pronto ");
                            break;
                        default:
                            Console.WriteLine("¡Digite un opcion valida!");
                            break;
                    }
                    Console.ReadKey();
                } while (op != 5);


            }
        }
    }
}
