using System;

namespace OrientacaoObjeto.Domain
{
    // TODO 4 - Herança: "É um" - Funcionário é uma pessoa
        
    public class Emitente : Pessoa
    {
        public Emitente(string Nome) : base(Nome)
        {
        }

        public Emitente() : base("Emitente")
        {
        }

        // TODO 6.2 - Override: Modificador que define o comportamento exigidos (abstract) ou altera comportamentos opcionais (virtual) de uma herança
        public override bool ValidarDocumento()
        {
            //Regra: Emitemte sempre terá CNPJ: Validar CNPJ.
            return true;
        }

        public override string MontarEndereco(string Logradouro, string Bairro, string Cidade, string Cep)
        {
            return $"Endereço do Emitente: {base.MontarEndereco(Logradouro,Bairro,Cidade,Cep)}";
        }
    }
}