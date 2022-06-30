namespace ReceitasMvc.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public string ModoDePreparo { get; set; }
        public int TempoDePreparo { get; set; }
        public int Porcao { get; set; }
        public bool Status { get; set; }
    }
}