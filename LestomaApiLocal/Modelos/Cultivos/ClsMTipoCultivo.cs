using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Cultivos
{
    [Table("TipoCultivos", Schema = "Cultivos")]
    public class ClsMTipoCultivo
    {
        [Key]
        [Display(Name = "Identificador unico del cultivo")]
        public Guid? TipCltId { get; set; }

        [Display(Name = "Nombre del tipo de cultivo")]
        [Column(TypeName="varchar(30)")]
        public string? TipCltNombre { get; set; }

        [Display(Name ="Descripcion del cultivo")]
        [Column(TypeName ="varchar(50)")]
        public string? TipCltDescripcion { get; set; }

    }
}
