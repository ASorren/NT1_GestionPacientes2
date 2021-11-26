using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NT1_GestionPacientes2.Models
{
    public class Paciente
    {   
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String beneficio { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int edad { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public String telefono { get; set; }

        public String email { get; set; }

        public String notas { get; set; }

    }
}
