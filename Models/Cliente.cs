namespace ProjetoNovo.Models
{
    public class Cliente
    {
        public string? _nome {get; set;}
        public string? _email {get; set;}


        public Cliente(string nome, string email)
        {
            _nome = nome;
            _email = email;
        }

        public Cliente(){}
    }
}