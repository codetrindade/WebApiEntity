using System.ComponentModel.DataAnnotations;

namespace WebApiEntity.Models
{

    public class Cliente
    {
        [Key]
        public string? cliente { get; set; }
        public string? Nome { get; set; }
        public string? NomeFiscal { get; set; }
        public DateTime DataCriacao { get; set; }
        public double? TotalDeb { get; set; }
        //public string? fac_local { get; set; }
        //public string? fac_cp { get; set; }
        //public string? totalDeb { get; set; }
        //public string? ActividadeEmpresarial { get; set; }

    }
}
