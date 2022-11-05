using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clase = new Class1();
            string palabra = "";
            string cantidad = "";


            Console.WriteLine("Ingrese la frase: ");
            palabra = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            cantidad = Console.ReadLine();
            clase.Justificar(palabra, int.Parse(cantidad));
            //Console.Write(respuesta);
        }
    }
}
