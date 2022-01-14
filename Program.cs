using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
            double num1, num2, res;
            static void Main(string[] args)
            {

            int opc;
            opc = 0;
            while (opc != 5)
            {
                Console.WriteLine("\t\tOperaciones Aritemticas\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3.Multiplciacion");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Salir\n");
                Console.WriteLine("Selecciona una opcion");
                opc = Convert.ToInt32(Console.ReadLine());

                Program datos = new Program();

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\t\tSuma de numeros\n");
                        datos.Capturar();
                        datos.res = datos.num1 + datos.num2;
                        Console.WriteLine("La suma es {0}", datos.res);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t\tResta de numeros\n");
                        datos.Capturar();
                        datos.res = datos.num1 - datos.num2;
                        Console.WriteLine("La Resta es {0}", datos.res);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\t\tMultiplicacion de numeros\n");
                        datos.Capturar();
                        datos.res = datos.num1 * datos.num2;
                        Console.WriteLine("La Multiplicacion es {0}", datos.res);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\t\tDivision de numeros\n");
                        datos.Capturar();
                        if (datos.num2 == 0)
                        {
                            Console.WriteLine("No se permiten divisiones entre cero");
                        }
                        else
                        {
                            datos.res = datos.num1 / datos.num2;
                            Console.WriteLine("La division es {0}", datos.res);
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadKey();

                        break;
                }
            }
            Console.ReadKey();
            }
            public void Capturar()
            {
                Console.WriteLine("Capture un numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Capture un numero");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
        
    }
}
