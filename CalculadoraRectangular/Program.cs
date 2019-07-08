using System;

namespace CalculadoraRectangular
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            var seguirEjecutando = true;
            while (seguirEjecutando)
            {
                Console.WriteLine("Bienvenido a la calcudora de area de rectangulos, por favor escribir Numeros y no letras");

                Console.Write("Escriba el valor del lado A : ");

                var ladoA = 0.0;
                var respuestaLadoA = double.TryParse(Console.ReadLine(), out ladoA);

                if(!respuestaLadoA)
                {
                    mostrarError();
                    continue;
                }

                Console.Write("Escriba el valor del lado B : ");

                var ladoB = 0.0;
                var respuestaLadoB = double.TryParse(Console.ReadLine(), out ladoB);

                if (!respuestaLadoB)
                {
                    mostrarError();
                    continue;
                }

                Console.WriteLine("El area del rectangulo es : " + (ladoA * ladoB));
                Console.WriteLine("Escriba S para salir del programa, Escriba cualquier otra tecla para repetir,");

                var eleccion = Console.ReadLine();

                if(eleccion.ToLower() == "s")
                {
                
                    break;
                } else
                {
                    Console.Clear();

                }


            }
            
            Console.WriteLine("Gracias por utilizar nuestro programa!");
        }


       static void mostrarError()
        {
            Console.Beep();
            Console.WriteLine("Favor ingresar un valor valido, presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }






    }
}
