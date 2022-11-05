using System;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Scramble scramble = new Scramble();
            string palabra1 = "";
            string palabra2 = "";


            Console.WriteLine("Ingrese la primera palabra: ");
            palabra1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda palabra: ");
            palabra2 = Console.ReadLine();
            bool respuesta = scramble.Validador(palabra1, palabra2);
            Console.Write(respuesta);
        }
    }
}
