using System.ComponentModel.DataAnnotations;

namespace ReceitasMvc.DTO
{
    public class IngredienteDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome de ingrediente é obrigatório!")]
        [StringLength(100, ErrorMessage = "Nome de ingrediente é muito grande, tente um número menor!")]
        [MinLength(2, ErrorMessage = "Nome da ingrediente é muito pequeno, informe um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }
    }
}