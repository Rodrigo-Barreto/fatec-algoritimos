using System;

namespace porcetagemDeFalta
{
    class Program
    {
        static void Main(string[] args)
        {
            double media,porcent;
            string message;
            

            Console.WriteLine("Informe a media do aluno: ");
            media = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe Freguencia do aluno: ");
            porcent = double.Parse(Console.ReadLine());
            
            if(media >=7 && porcent >= 75)
            {
                message = "Passou";
            }
            else
            {
                message = "Não passou";
            }

            Console.WriteLine(message);
            Console.ReadLine();

           



        }
    }
}
