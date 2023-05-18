using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LestomaApiLocal.Modelos.Cultivos
{
    [Table("DatosCultivo", Schema = "Cultivos")]
    public class ClsMDatosCultivo
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? DtcId { get; set; }

        [Display(Name = "Identificador del cultivo")]
        public Guid? DtcClvId { get; set; }

        [Display(Name = "Fecha y hora de la toma de los datos")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateAndTime? DtcFchHra { get; set; }

        [Display(Name = "Identificador del sensor")]
        public Guid? DtcSnsId { get; set; }

        [Display(Name = "Valor Tomado por el sensor")]
        public float? DtcValor { get; set; }

        [Display(Name = "Valor de sincronizacion de datos")]
        public bool DtcSincronización { get; set; }
    }
}
