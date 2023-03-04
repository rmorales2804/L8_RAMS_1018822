using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_RAMS_1018822
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LABORATORIO 8");
            Console.WriteLine("a. Sumatoria");
            Console.WriteLine("b. Mostrar tablas de multiplicar");
            Console.WriteLine("c. Número perfecto");
            Console.Write("Elija la opción que desea: ");
            string opcion = Console.ReadLine();

            switch (opcion)
                {
                case "a":
                    Console.Write("Ingrese un numero: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int suma = 0;
                    int i = 1;
                    do
                    {
                        suma = suma + i;
                        i++;

                    } 
                    while (i <= n);
                    Console.WriteLine("La suma de los números de 1 a " + n + " es:" + suma);
                    break;

                case "b":
                    Console.Write("Ingrese un número: ");
                    int tabla = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Tabla del " + tabla + ": ");

                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(tabla + "x" + j + " = " + (tabla * j));
                    }                                       
                    break;

                case "c":
                    Console.Write("Ingrese un número: ");
                    int numero = 0;
                    string b = Console.ReadLine();
                    
                    bool op = int.TryParse("i", out numero);
                    if (op == false)
                    {
                        numero = Convert.ToInt32(b);

                        if (numero <= 0)
                        {
                            Console.WriteLine("El número debe ser mayor a 0.");
                        }
                        else
                        {
                            int sumadivisores = 0;
                            for (int a = 1; a < numero; a++)
                            {
                                if (numero % a == 0)
                                {
                                    sumadivisores = sumadivisores + a;
                                }
                            }
                            if (sumadivisores == numero)
                            {
                                Console.WriteLine("El número " + numero + " es un número perfecto.");
                            }
                            else
                            {
                                Console.WriteLine("El número " + numero + " no es un número perfecto.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usted ingreso una letra");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }


            Console.ReadKey();
        }
    }
}
