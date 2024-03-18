using System.ComponentModel.DataAnnotations;

namespace back.Models
{
    public class Endereco
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Logradouro Obrigatório")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Logradouro Obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero Obrigatório")]
        public int Numero { get; set; }

        
    }
}
