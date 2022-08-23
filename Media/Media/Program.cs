using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {

            double nota1,nota2,nota3,nota4 ;
            double media = 0;
            string texto = "";
           
            

          
            Console.WriteLine("Digite a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());



            media = (nota1+nota2 + nota3 + nota4) / 4;
    
            if (media >= 7)
            {
                 texto = "Passou. Sua nota é: " + media;


            } else if(media <= 5)
            {
                texto = "Reprovado. Sua nota é: " + media;
               

            }
            else
            {
                texto = "Exame. Sua nota é: " + media;
               

            }


            Console.WriteLine(texto);
            Console.ReadLine();


        }
    }
}
