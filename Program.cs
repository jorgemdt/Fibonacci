using System;

namespace Fibonacci
{
    class App
    {

        static void Main(string [ ] args)
        {
            while ( true )
            {
                Console.WriteLine("Digite quantos números quer na Sequência?( Maximo 93.) ");
                string input = Console.ReadLine();
                Console.WriteLine("====================================================");

                if ( !ulong.TryParse(input, out ulong number) || number <= 0 || number > 93 )
                {
                    Console.WriteLine("Apenas números inteiros entre 1 e 93!");
                    Console.WriteLine();
                    Console.WriteLine("====================================================");

                    continue;
                }

                //ulong numberFinal = 12200160415121876738;
                ulong x = 1, y = 0, z;

                for ( ulong i = 0; i < number; i++ )
                {
                    z = x + y;
                    if ( y > z )
                    {
                        Console.WriteLine("impreciso...");
                    }
                    else
                    {
                        Console.WriteLine(z.ToString("#,#,#,#,#,#"));
                    }
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