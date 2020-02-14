namespace OrientacaoObjeto.Domain
{
    // TODO 5.1 - Abstração: Fornecer estados e comportamentos genéricos para um grupo de outras classes que compartilham estados e comportamentos comuns.

    // TODO 5.2 - Abstract: O modificador abstract da classe serve para dizer para o resto do projeto que está classe não pode ser instanciada diretamente,
    //Apenas por uma herança
    public abstract class Pessoa
    {
        // TODO 3.1 - Estado: São as propriedades e variaveis da classe... 
        //São informações que a classe possui.

        private readonly string _nome;
        public string Endereco { get; set; }

        public Pessoa(string nome)
        {
            _nome = nome;
        }

        // TODO 3.2 - Comportamento: São métodos que processam informação, retornam ou não informação ou apenas alteram e estado da classe manipulando suas propriedades.

        // TODO 5.3 - Virtual: O modificador virtual server para definir um comportamento genérico, porém deixando
        // a possibilidae de qualquer classe que herdar poder reescrever o comportamento.
        public virtual string MontarEndereco(string logradouro, string bairro, string cidade, string cep)
        {
            var endereco = $"Endereço {_nome}: {logradouro} - {bairro} / {cidade} -> {cep}";
            Endereco = endereco;
            return endereco;
        }
        
        // TODO 5.4 - Abstract: modificador abstract do metodo serve para definir comportamentos comuns ao grupo,
        //porém cada membro do grupo executa esse comportamento de uma determinada maneira.
        public abstract bool ValidarDocumento();
    }
}