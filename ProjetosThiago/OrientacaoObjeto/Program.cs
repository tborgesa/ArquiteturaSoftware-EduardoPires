using System;
using OrientacaoObjeto.Tests;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("");
            Console.WriteLine("1 - Herança");
            Console.WriteLine("Pressione qualquer outra para finalizar.");

            var opcao = Console.ReadKey();

            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    new Heranca().Execucao();
                    break;
                default:
                    return;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Fim do Processo");
            Console.WriteLine("Aperte qualquer tecla para recomeçar.");

            Console.ReadKey();

            Console.Clear();

            Main(null);
        }
    }
}
