using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Tanques
{
    [Table("DatosTanque", Schema = "Tanques")]
    public class ClsMDatosTanque
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? DtqId { get; set; }

        [Display(Name = "Identificador del tanque")]
        public Guid? DtqTgsId { get; set; }

        [Display(Name = "Fecha y hora de la toma de los datos")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateAndTime? DtqFchHra { get; set; }

        [Display(Name = "Identificador del sensor")]
        public Guid? DtqSnsId { get; set; }

        [Display(Name = "Valor Tomado por el sensor")]
        public float? DtqValor { get; set; }

        [Display(Name ="Valor de sincronizacion de datos")]
        public bool DtqSincronización { get; set; }

    }
}
