namespace ProjetoNovo.Models
{
    public class Carro
    {
        public string? _nome {get; set;}
        public decimal _preco {get; set;}

        public Carro(string nome, decimal preco)
        {
            _nome = nome;
            _preco = preco;
        }
    }
}