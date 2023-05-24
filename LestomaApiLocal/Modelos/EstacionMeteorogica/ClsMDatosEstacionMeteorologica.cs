using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.EstacionMeteorogica
{
    [Table("DatosEstacionMeteorologica", Schema = "EstacionMeteorologica")]
    public class ClsMDatosEstacionMeteorologica
    {
        [Key]
        [Display(Name = "Identifocador unico del dato")]
        public Guid? DtemId { get; set; }

        [Display(Name = "Identificador de la Estacion Meteorologica")]
        public Guid? DtemEtMgaId { get; set; }

        [Display(Name = "Fecha y hora de toma de los datos")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime DtemFchHraDtemFchHra { get; set; }

        [Display(Name = "Identificador unico del sensor")]
        public Guid DtemSnsId { get; set; }

        [Display(Name = "Valor tomado por el sensor")]
        public float DtemValor { get; set; }

        [Display(Name = "Sincronizacion de los datos")]
        public bool DtemSincronización { get; set; }
    }
}
