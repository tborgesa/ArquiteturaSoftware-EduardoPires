using System;
using OrientacaoObjeto.Domain;

namespace OrientacaoObjeto.Tests
{
   public class Objeto
    {
        public Objeto()
        {
            // TODO 2 - Objeto é uma classe sendo instanciada e alocada na memória
            var casa = new NotaFiscal
            {
                NomeEmissor = "Emissor",
                NomeDestinatario = "Destinatário",
                DataEmissao = DateTime.Now,
                ValorTotal = 4
            };

            Console.WriteLine(casa.NomeEmissor);
        }
    }
}