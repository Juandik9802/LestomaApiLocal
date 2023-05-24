using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Biodigestor
{
    [Table("Biodigestor", Schema = "Biodigestor")]
    public class ClsMBiodigestor
    {
        [Key]
        [Display(Name="Indicador Unico")]
        public Guid? BgrId { get; set; }

        [Display(Name ="Fecha de inicio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime BgrFchInicio { get; set; }

        [Display(Name ="Facha de finalizacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime BgrFchFin { get; set; }

        [Display(Name ="Identifiador la upa")]
        public Guid? BgrUpsId { get; set; }
    }
}
