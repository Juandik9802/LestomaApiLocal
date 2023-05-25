using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Configuracion
{
    [Table("Observacion", Schema = "Configuracion")]
    public class ClsMObservacion
    {
        [Key]
        [Display(Name = "Identificador unico de la configuracion")]
        public Guid ObsId { get; set; }

        [Display(Name = "Identificador del ususario que hace la obsevacion")]
        public Guid ObsIdUsuario { get; set; }

        [Display(Name = "Fecha de la observacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime ObsFecha { get; set; }

        [Display(Name = "Observacion del usuario")]
        [Column(TypeName = "varchar(150)")]
        public string? ObsDescripcion { get; set; }

        [Display(Name = "Relevancia de la observacion")]
        [Column(TypeName = "varchar(50)")]
        public string? ObsRelevancia { get; set; }

        [Display(Name = "Sincronizacion")]
        public bool? ObsSincronizacion { get; set; }

    }
}
