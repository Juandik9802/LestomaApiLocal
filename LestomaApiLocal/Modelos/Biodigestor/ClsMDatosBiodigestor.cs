using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Biodigestor
{
    [Table("DatosBiodigestor", Schema = "Biodigestor")]
    public class ClsMDatosBiodigestor
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? DtbId { get; set; }

        [Display(Name = "Identificador del Biodigestor")]
        public Guid? DtbBgrId { get; set; }

        [Display(Name = "Fecha y hora de toma de los datos")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime DtbFchHra { get; set; }

        [Display(Name = "Identificador unico del sensor")]
        public Guid DtbSnsId { get; set; }

        [Display(Name = "Valor tomado del sensor")]
        public float DtbValor { get; set; }

        [Display(Name = "Valor de sincronizacion")]
        public bool DtbSincronización { get; set; }
    }
}
