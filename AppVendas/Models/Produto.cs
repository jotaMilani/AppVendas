using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo não pode estar vazio!")]
        [MaxLength(100, ErrorMessage = "O campo deve ter, no maximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve ter, no minimo, 3 caracteres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser um numero positivo!")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo não pode estar vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser um numero positivo!")]
        [Display(Name = "Estoque Atual")]

        public double QtadeEstoque { get; set; }
        [Display(Name = "Ativo?")]

        public bool CadastroAtivo { get; set; } = true;
        [Required(ErrorMessage = "Por favor, selecione uma categoria")]
        public Guid CategoriaID { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
