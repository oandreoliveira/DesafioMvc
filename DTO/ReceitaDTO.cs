using System.ComponentModel.DataAnnotations;

namespace ReceitasMvc.DTO
{
    public class ReceitaDTO
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Inserir uma imagem é obrigatório")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Nome da receita é obrigatório!")]
        [StringLength(100, ErrorMessage = "Nome da receita é muito grande, tente um número menor!")]
        [MinLength(2, ErrorMessage = "Nome da receita é muito pequeno, informe um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Categoria da receita é obrigatória!")]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Modo de preparo da receita é obrigatório!")]
        [MinLength(100, ErrorMessage = "Modo de preparo muito curto, você precisa detalhar melhor o passo a passo. Mínimo de 100 caracteres!")]
        public string ModoDePreparo { get; set; }
        [Required(ErrorMessage = "Tempo de preparo da receita é obrigatório!")]
        public int TempoDePreparo { get; set; }
        [Required(ErrorMessage = "Quantidade de Porções da receita é obrigatório!")]
        public int Porcao { get; set; }

    }
}