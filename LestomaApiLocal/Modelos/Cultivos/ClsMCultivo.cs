using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Cultivos
{
    [Table("Plantas", Schema = "Tanques")]
    public class Cultivo
    {
        [Key]
        [Display(Name ="Identificador unico")]
        public Guid? ClvId { get; set; }

        [Display(Name ="Identificador del tipo de cultivo")]
        public Guid? ClvTpcId { get; set; }

        [Display(Name ="Identificador de la planta")]
        public Guid? ClvPltId { get; set; }

        [Display(Name = "Fecha de cracion del cultivo")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ClvFchInicio { get; set; }

        [Display(Name="Cantidad de peces")]
        public int ClvCtdInicial { get; set; }

        [Display(Name ="Fecha salida de peces")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ClvFchFin { get; set; }

        [Display(Name ="Cantidad finale de peces")]
        public int ClvCtdFinal { get; set; }

        [Display(Name ="Identificador de UPA")]
        public Guid? ClvUpsId { get; set; }

    }
}
