using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LestomaApiLocal.Modelos.Tanques
{
    [Table("Tanque", Schema = "Tanques")]
    public class Tanques
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? TqsId { get; set; }

        [Display(Name = "Identificador de pescado")]
        public Guid? TqsIdPez { get; set; }

        [Display(Name = "Fecha de ingreso de los peces en el tanque")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaIngreso { get; set; }

        [Display(Name = "Cantidad de inicial de peces")]
        public int? TqsCtdInicial { get; set; }

        [Display(Name = "Fecha de salida de los peces del tanque")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? TqsFchSalida { get; set; }

        [Display(Name = "Cantidad de final de peces")]
        public int? TqsCtdFinal { get; set; }

        [Display(Name = "Identificador de la UPA")]
        public Guid? TqsUpsId { get; set; }

        [Display(Name = "Estado actual del tanque")]
        public Guid? TqsIdEstado { get; set; }

        [Display(Name = "Estado actual de la sincronia")]
        public bool? Sinccronizacion { get; set; }

    }
}
