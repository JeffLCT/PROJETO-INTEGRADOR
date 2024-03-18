using System.ComponentModel.DataAnnotations;

namespace back.Models
{
    public class Endereço
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
