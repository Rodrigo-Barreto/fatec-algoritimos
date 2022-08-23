using System;

namespace Votacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano,range = 0;
            string message; 

            Console.WriteLine("Informe seu ano de nascimento");
            ano = int.Parse(Console.ReadLine());

            range = 2022 -  ano  ;


            if (range >= 18 && range <= 60) {

                message = "Voto obrigatorio";

            }else if(range < 16)
            {
                message = "Voto não disponivel";
            }
            else
            {
                message = "Voto Opcional";

            }

            Console.WriteLine(message);
            Console.ReadLine();

        


        }
    }
}
