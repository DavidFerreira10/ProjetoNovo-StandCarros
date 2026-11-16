namespace ProjetoNovo.Models.dados
{
    public class dadosViewModel
    {
        public required List<Carro>? Carros { get; set; }
        public List<CarrosUsados>? carroUsado { get; set; }
        public Cliente? Cliente { get; set; }
    }
    
}