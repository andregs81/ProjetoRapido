using System.ComponentModel.DataAnnotations;

namespace ProjetoRapido.Services.ViewModel
{
    public class ClienteViewModel
    {
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo {1} caracteres")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome obrigatório")]
        [MinLength(5, ErrorMessage = "O sobrenome deve ter no mínino {1} caracteres")]
        [Display(Name = "Sobrenome")]
        public string SobreNome { get; set; }

        public int? EnderecoID { get; set; }

        [Required(ErrorMessage = "O Cep obrigatório")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O logradouro obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O numero obrigatório")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "O bairro obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O cidade obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O estado obrigatório")]
        public string Estado { get; set; }

    }
}
