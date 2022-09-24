using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AulaWeb2MVC.Models
{
    [Table("Faculdade")]
    public class FaculdadeModel
    {
        [Key]
        [Column("Fac_Id")]
        public long Id { get; set; }

        [Column("Fac_Nome_Fantasia")]
        [Display(Name = "Nome fantasia")]
        public string NomeFantasia { get; set; }

        [Column("Fac_Nome_Completo")]
        [Display(Name = "Nome completo")]
        public string NomeCompleto { get; set; }
    }
}
