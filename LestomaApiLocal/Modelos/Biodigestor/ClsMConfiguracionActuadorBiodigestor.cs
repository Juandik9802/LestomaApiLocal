using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LestomaApiLocal.Modelos.Biodigestor
{
    [Table("ConfiguracionActuadorBiodigestor", Schema = "Biodigestor")]
    public class ClsMConfiguracionActuadorBiodigestor
    {
        [Key]
        [Display(Name = "Identificador unico de la configuracion")]
        public Guid? CfgAtdBgrId { get; set; }

        [Display(Name = "Identificador del Biodigestor")]
        public Guid? CfgAtdBgrBgrId { get; set; }

        [Display(Name = "Identificador unico del usuario")]
        public Guid? CfgAtdBgrUsrId { get; set; }

        [Display(Name = "Fecha y hora de la modificacion del actuador")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd--hh--mm}", ApplyFormatInEditMode = true)]
        public DateTime CfgAtdBgrFchHra { get; set; }

        [Display(Name ="Identificador del actuador")]
        public Guid CfgAtdBgrAtdId { get; set; }

        [Display(Name = "Valor del actuador (PWM)")]
        public int CfgAtdBgrPwmValor { get; set; }

        [Display(Name = "Valor del setpoint")]
        public float CfgAtdBgrStpValor { get; set; }

        [Display(Name = "Sincronizacion de la configuracion")]
        public bool CfgAtdBgrSincronización { get; set; }

    }
}
