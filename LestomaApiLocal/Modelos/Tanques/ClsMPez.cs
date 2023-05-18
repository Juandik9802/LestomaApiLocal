using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Tanques
{
    [Table("Pez", Schema = "Tanques")]
    public class Pez
    {
        [Key]
        [Display(Name ="Identificador unico")]
        public Guid? PezId { get; set; }

        [Display(Name ="Nombre del Pez")]
        [Column(TypeName = "varchar(30)")]
        public string? PezNombre { get; set;}
    }
}
