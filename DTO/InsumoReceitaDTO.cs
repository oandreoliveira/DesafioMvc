using System.Collections.Generic;
using ReceitasMvc.Models;

namespace ReceitasMvc.DTO
{
    public class InsumoReceitaDTO
    {
        public int Id { get; set; }
        public int ReceitaID { get; set; }
        public int Quantidade { get; set; }
        public int MedidaID { get; set; }
        public int IngredienteID { get; set; }
        public IEnumerable<Receita> Receitas { get; set; } // lista de receitas para instanciar na controler e renderizar junto com o DTO

    }
}