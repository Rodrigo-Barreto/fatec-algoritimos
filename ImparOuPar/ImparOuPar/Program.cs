using System;

namespace ImparOuPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int resto;

            Console.WriteLine("Informe um numero :");
            n = int.Parse(Console.ReadLine());
            resto = n % 2;

            Console.WriteLine(resto==0? "Par":"Impar");
            Console.ReadLine();

     
        }
    }
}
