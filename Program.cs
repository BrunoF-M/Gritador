using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string textodigitado;

            Console.WriteLine("digite algo... ");
            textodigitado = Console.ReadLine();
            
            Console.WriteLine($"{textodigitado}".ToUpper());
        }
    }
}
