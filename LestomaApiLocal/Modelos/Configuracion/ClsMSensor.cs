using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Configuracion
{
    [Table("Sensor", Schema = "Configuracion")]
    public class ClsMSensor
    {
        [Key]
        [Display(Name = "Identificador unico de la configuracion")]
        public Guid SnsId { get; set; }

        [Display(Name = "Nombre del sensor")]
        [Column(TypeName = "varchar(50)")]
        public string SnsNombre { get; set; }

        [Display(Name = "Identificador del estado")]
        public Guid SnsEtdId { get; set; }


    }
}
