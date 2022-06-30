using System.ComponentModel.DataAnnotations;

namespace ReceitasMvc.DTO
{
    public class MedidaDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome da unidade de medida é obrigatório!")]
        [StringLength(100, ErrorMessage = "Nome da unidade de medida é muito grande, tente um número menor!")]
        [MinLength(2, ErrorMessage = "Nome da unidade de medida é muito pequeno, informe um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }
    }
}