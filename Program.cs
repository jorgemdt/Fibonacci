using System;

namespace Fibonacci
{
    class App
    {

        static void Main(string [ ] args)
        {
            while ( true )
            {      
                Console.WriteLine("Digite quantos números quer na Sequência?( ATÉ 90.) ");
                string input = Console.ReadLine();

                if ( !long.TryParse(input, out long number) || number <= 0 || number > 90 )
                {
                    Console.WriteLine("Apenas números inteiros entre 1 e 90!");
                    Console.WriteLine();
                    continue;
                }
                               
                long x = 1, y = 0, z = 0;

                for ( long i = 0; i < number; i++ )
                {
                    z = x + y;

                    Console.WriteLine(z);

                    x = y; y = z;
                }
                while ( true )
                {
                Console.WriteLine();
                Console.WriteLine("Gostaria de continuar?(y/n)");
                string resposta = Console.ReadLine();

                    if ( resposta == "y" )
                    {
                        break;
                    }
                    else if ( resposta == "n" )
                    { 
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Apenas y ou n.");
                        continue;
                    }

                }


            }

        }

    }
}