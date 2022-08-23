using System;

namespace NumerosMaiores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string message;

            Console.WriteLine("Informe o numero 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero 2: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                message = "O " + num1 + " é o maior";

            }
            else if (num2>num1)
            {
                message = "O " + num2 + " é o maior";
            }
            else
            {
                message = "Numeros iguais";
            }

            Console.WriteLine(message);
           Console.ReadLine();

        }
    }
}
