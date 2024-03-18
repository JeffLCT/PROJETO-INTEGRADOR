using System.ComponentModel.DataAnnotations;

namespace back.Data.DTOs.Endereço
{
    public class UpdateusuarioDTO
    {

        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string sobrenome { get; set; }

        [Required]
        public string email { get; set; }
        [Required]
        public string telefone { get; set; }

        [Required]
        public string cpf { get; set; }

        [Required]
        public string senha { get; set; }

    }
}
