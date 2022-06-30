namespace ReceitasMvc.Models
{
    public class InsumoReceita
    {
        public int Id { get; set; }
        public Receita Receita { get; set; }
        public int Quantidade { get; set; }
        public Medida Medida { get; set; }
        public Ingrediente Ingrediente { get; set; }

    }
}