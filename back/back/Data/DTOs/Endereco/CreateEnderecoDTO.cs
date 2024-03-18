using System.ComponentModel.DataAnnotations;

namespace back.Data.DTOs.Endereco
{
    public class CreateEnderecoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Logradouro Obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero Obrigatório")]
        public int Numero { get; set; }
    }
}
