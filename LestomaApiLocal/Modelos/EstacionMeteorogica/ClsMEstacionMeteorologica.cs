using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.EstacionMeteorogica
{
    [Table("EstacionMeteorologica", Schema = "EstacionMeteorologica")]
    public class ClsMEstacionMeteorologica
    {
        [Key]
        [Display(Name = "Identificador unico de la estacion")]
        public Guid? EtMtgaId { get; set; }

        [Display(Name = "Ubicacion de la estacion")]
        [Column(TypeName = "varchar(50)")]
        public string? EtMtgaUbicacion { get; set; }

        [Display(Name = "Identificador de la UPA")]
        public Guid? EtMtgaUpsIdEtMtgaUpsId { get; set; }
    }
}
