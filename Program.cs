using System;

namespace Fibonacci
{
    class App
    {
        static void Main(string [ ] args)
        {
            while ( true )
            {
                Console.WriteLine("Digite quantos números quer na Sequência?( Maximo 135.) ");
                string input = Console.ReadLine();
                Console.WriteLine("====================================================");

                if ( !ulong.TryParse(input, out ulong number) || number <= 0 || number > 135 )
                {
                    Console.WriteLine("Apenas números inteiros entre 1 e 135!");
                    Console.WriteLine();
                    Console.WriteLine("====================================================");

                    continue;
                }

                //ulong numberFinal = 12200160415121876738;
                decimal x = 1, y = 0, z;

                for ( ulong i = 0; i < number; i++ )
                {
                    z = x + y;

                    Console.WriteLine(z.ToString("#,#,#,#,#,#"));

                    x = y; y = z;

                }
                while ( true )
                {
                    Console.WriteLine();
                    Console.WriteLine("Gostaria de continuar?(y/n)");
                    string resposta = Console.ReadLine();
                    Console.WriteLine("====================================================");


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
                        Console.WriteLine("====================================================");
                        continue;
                    }

                }


            }

        }

    }
}