namespace ProjetoNovo.Models
{
    public class CarrosUsados
    {
        public string? _nome {get; set;}
        public decimal _preco {get; set;}

        public int _ano {get; set;}

        public CarrosUsados(string nome, decimal preco, int ano)
        {
            _nome = nome;
            _preco = preco;
            _ano = ano;
        }
    }
}