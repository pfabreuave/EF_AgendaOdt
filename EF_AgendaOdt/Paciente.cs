using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AgendaOdt
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int ID { get; set; }
        public string NOME { get; set; }
        public string CPF { get; set; }
        public string DATA_NASCIMENTO { get; set; }
        public string DATA_AGENDA { get; set; }
        public int HORA_INICIO { get; set; }
        public int HORA_FIM { get; set; }
    }
}
