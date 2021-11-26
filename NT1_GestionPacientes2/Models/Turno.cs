using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NT1_GestionPacientes2.Models
{
    public class Turno
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String nombre { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        public DateTime horario { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String tipoConsulta { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String obraSocial { get; set; }


    }
}
