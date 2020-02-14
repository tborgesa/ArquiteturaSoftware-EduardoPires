using System;

namespace OrientacaoObjeto.Domain
{
    public class NotaFiscal
    {
        // TODO 1 - Classe: Classe é uma representação de algum coisa do mundo real
        //em forma de código
        public string  NomeEmissor { get; set; }
        public string  NomeDestinatario { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal ValorTotal { get; set; }
    }
}