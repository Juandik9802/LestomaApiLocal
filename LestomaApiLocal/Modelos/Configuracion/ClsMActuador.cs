using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Configuracion
{
    [Table("Actuador", Schema = "Configuracion")]
    public class ClsMActuador
    {
        [Key]
        [Display(Name = "Identificador unico de la configuracion")]
        public Guid AtdId { get; set; }

        [Display(Name = "Nombre del actuador")]
        [Column(TypeName = "varchar(50)")]
        public string AtdNombre { get; set; }

        [Display(Name = "identificador del estado del actuador")]
        public Guid AtdEtdId { get; set; }


    }
}
