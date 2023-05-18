using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LestomaApiLocal.Modelos.Cultivos
{
    [Table("Plantas", Schema = "Cultivos")]
    public class ClsMPlantas
    {
        [Key]
        [Display(Name = "Identificador unico")]
        public Guid? PltId { get; set; }

        [Display(Name ="Nombre del pez")]
        [Column(TypeName = "varchar(50)")]
        public String? PtlNombre { get; set; }
    }
}
