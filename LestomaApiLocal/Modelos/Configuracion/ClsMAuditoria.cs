using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Configuracion
{
    [Table("Auditoria", Schema = "Configuracion")]
    public class ClsMAuditoria
    {
        [Key]
        [Display(Name = "Identificador de la uditoria")]
        public Guid? AdtIdAditoria { get; set; }

        [Display(Name = "Fecha y hora de la modificacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime AdtFchHora { get; set; }

        [Display(Name = "Tabla que se modifico")]
        [Column(TypeName = "varchar(50)")]
        public string AdtTabla { get; set; }

        [Display(Name = "Accion en la tabla")]
        [Column(TypeName = "varchar(50)")]
        public string AdtAccion { get; set; }

        [Display(Name = "Valor anterior ")]
        [Column(TypeName = "varchar(50)")]
        public string AdtVlrAnterior { get; set; }

        [Display(Name = "Valor nuevo ")]
        [Column(TypeName = "varchar(50)")]
        public string AdtVlrNuevo{ get; set; }

    }
}
