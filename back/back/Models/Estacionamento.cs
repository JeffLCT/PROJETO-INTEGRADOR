using System.ComponentModel.DataAnnotations;

namespace back.Models
{
    public class Estacionamento
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatorio.")]
        public string Nome { get; set; }

        [Required]
        public int QuantidadeVagas { get; set; }
        [Required]
        public int QuantidadeVagasDisponiveis { get; set; }

    }
}
