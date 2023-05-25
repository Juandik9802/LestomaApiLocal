using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace LestomaApiLocal.Modelos.Configuracion
{
    [Table("Estado", Schema = "Configuracion")]
    public class ClsMEstado
    {
        [Key]
        [Display(Name = "Identificador unico para el estado")]
        public Guid EtdId { get; set; }

        [Display(Name = "Estado")]
        [Column(TypeName = "varchar(50)")]
        public string EtdDescripcion { get; set; }

        [Display(Name = "Explicacion breve del estado")]
        [Column(TypeName = "varchar(50)")]
        public string? EtdComentario { get; set; }

    }
}
