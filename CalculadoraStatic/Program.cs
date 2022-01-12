using System;

namespace CalculadoraStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            char continuar = 's';

            while (continuar != 'n' && continuar != 'N') 
            { 
                try
                {
                    
                    Console.WriteLine("Coloque dos numeros enteros separados por un ENTER: ");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ahora elija una opcion: ");
                    Console.WriteLine("1) Suma");
                    Console.WriteLine("2) Resta");
                    Console.WriteLine("3) Multiplicacion");
                    Console.WriteLine("4) Division entera");
                    c = int.Parse(Console.ReadLine());
                    Console.Write("RTA: ");
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine(suma(a, b));
                            break;
                        case 2:
                            Console.WriteLine(resta(a, b));
                           break;
                        case 3:
                            Console.WriteLine(multiplicacion(a, b));
                            break;
                        case 4:
                            Console.WriteLine(divicionEntera(a, b) + " Modulo: " + modulo(a, b));
                            break;
                        default:
                            Console.WriteLine("se eligio una opcion fuera de rango");
                            break;
                    }
                    Console.WriteLine("Para hacer otra cuenta presione una tecla distinta de 'n' o 'N', para terminar presione 'n' o 'N' ");
                    continuar = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine(continuar);
                
                } catch (FormatException ex)
                {
                    Console.WriteLine("Error: Se coloco un formato no valido");
                }
                
                
            }

        }
        static int suma(int a, int b)
        {
            return a + b;
        }
        static int resta(int a, int b)
        {
            return a - b;
        }
        static int multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int divicionEntera(int a, int b)
        {
            if(b==0)
                throw new Exception("Error: no se puede dividir 0 entre 0");
            return a / b;
        }
        static int modulo(int a, int b)
        {
            return a % b;
        }
    }
}
