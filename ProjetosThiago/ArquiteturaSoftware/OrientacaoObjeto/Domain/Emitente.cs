namespace OrientacaoObjeto.Domain
{
    // TODO 4 - Herança: "É um" - Funcionário é uma pessoa
    // TODO 6.1 - Polimorfismo - Muitos comportamentos para um mesmo método (herdado), especializando comportamentos da classe herdada.
    public class Emitente : Pessoa
    {
        public Emitente(string nome) : base(nome)
        {
        }

        public Emitente() : base("Emitente")
        {
        }

        // TODO 6.2 - Override: Modificador que define (sobrescrevendo) o comportamento exigidos (abstract) ou alterando comportamentos opcionais (virtual) de uma herança
        public override bool ValidarDocumento()
        {
            //Regra: Emitemte sempre terá CNPJ: Validar CNPJ.
            return true;
        }

        public override string MontarEndereco(string logradouro, string bairro, string cidade, string cep)
        {
            return $"Endereço do Emitente: {base.MontarEndereco(logradouro,bairro,cidade,cep)}";
        }
    }
}