using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PUC_DevBE.Models
{
    [Table("Veiculos")]
    public class Veículo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Nome do veículo!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Placa do veículo!")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação do veículo!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo do veículo!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
