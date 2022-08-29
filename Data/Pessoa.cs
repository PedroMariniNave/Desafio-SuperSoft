namespace Desafio.Data
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get => ConverterIdade(); }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        private int ConverterIdade()
        {
            DateTime now = DateTime.Now;
            int anoAtual = now.Year;
            int anoNascimento = DataNascimento.Year;
            int age = anoAtual - anoNascimento;
            if (now < DataNascimento.AddYears(age)) age--;

            return age;
        }
    }
}