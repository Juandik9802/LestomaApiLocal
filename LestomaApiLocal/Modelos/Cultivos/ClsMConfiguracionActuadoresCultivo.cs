using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Cultivos
{
    [Table("ConfiguracionActuadoresCultivo", Schema = "Cultivos")]
    public class ClsMConfiguracionActuadoresCultivo
    {
        [Key]
        [Display(Name ="identificador Unico")]
        public Guid? CfgAtdClvId { get; set; }

        [Display(Name ="Identificador del cultivo")]
        public Guid? CfgAtdClvClvId { get; set; }

        [Display(Name ="Identificador del usuario")]
        public Guid? CfgAtdCltUsrId { get; set; }

        [Display(Name ="Fecha y hora de lamodificacion")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime CfgAtdCltFchHra { get; set; }

        [Display(Name ="Identificador de el atuador del tanque")]
        public Guid? CfgAtdCltAtdId { get; set; }

        [Display(Name = "Valor del actuador (PWM)")]
        public int? CfgAtdCltValor { get; set; }

        [Display(Name= "Valor para conocer la sincronizasionde de la configuracion")]
        public bool CfgAtdCltSincronización { get; set; }
    }
}
