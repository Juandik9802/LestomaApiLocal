using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Tanques
{
    [Table("ConfiguracionActuadoresTanques", Schema = "Tanques")]
    public class ClsMConfiguracionTanque
    {
        [Key]
        [Display(Name ="Identificador unico")]
        public Guid? CfgAtdTqsId { get; set; }

        [Display(Name ="Identificador del tanque")]
        public Guid? CfgAtdTqsTqsId { get; set; }

        [Display(Name ="Identificador del usuario")]
        public Guid? CfgAtdTqsUsrId { get; set; }

        [Display(Name ="Fecha y hora de la modificacion")]
        [DataType(DataType.DateTime)]        
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime? CfgAtdTqsFchHra { get; set; }

        [Display(Name ="Identificador del actuador")]
        public Guid? CfgAtdTqsAtdId { get; set; }

        [Display(Name = "Valor del actuador (PWM)")]
        public int? CfgAtdTqsPwmValor { get; set; }

        [Display(Name = "Valor del setpoint")]
        public int? CfgAtdTqsStpValor { get; set; }

        [Display(Name ="Valor para conocer la sincronizasionde de la configuracion")]
        public bool CfgAtdTqsSincronización { get; set; }

    }
}
