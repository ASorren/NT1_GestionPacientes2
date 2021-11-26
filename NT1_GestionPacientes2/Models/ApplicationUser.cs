using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NT1_GestionPacientes2.Models
{
    public class ApplicationUser: IdentityUser 
    {
        [Required]
        public int TurnoId { get; set;}

        [ForeignKey("TurnoId")]
        public Turno Turno { get; set;}

        [ForeignKey("PacienteId")]
        public Paciente Paciente { get; set; }
    }
}
