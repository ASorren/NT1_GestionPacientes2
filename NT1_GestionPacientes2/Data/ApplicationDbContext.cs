using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NT1_GestionPacientes2.Models;

namespace NT1_GestionPacientes2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
