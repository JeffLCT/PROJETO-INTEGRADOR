using System.ComponentModel.DataAnnotations;

namespace back.Models
{
    public class Veiculo
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required] 
        public string codigoRenavam { get; set; }

        [Required]
        public string placa { get; set; }

        [Required]
        public string marca { get; set; }

        [Required]
        public string modelo { get; set; }

        [Required]
        public string AnoModelo { get; set; }

    }
}
