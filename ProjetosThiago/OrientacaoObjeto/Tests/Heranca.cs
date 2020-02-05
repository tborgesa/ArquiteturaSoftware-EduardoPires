using System;
using OrientacaoObjeto.Domain;

namespace OrientacaoObjeto.Tests
{
    public class Heranca
    {
        public void Execucao()
        {
            var emitente = new Emitente();
            Console.WriteLine(emitente.MontarEndereco("Rua Castro Alves, 1390", "Zona 06", "Maringá", "87015-440"));
        }
    }
}