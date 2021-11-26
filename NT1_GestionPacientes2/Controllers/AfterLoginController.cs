using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NT1_GestionPacientes2.Data;
using NT1_GestionPacientes2.Models;

namespace NT1_GestionPacientes2.Controllers
{
    public class AfterLoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AfterLoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Pacientes()
        {
            return View(await _context.Paciente.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Turnos()
        {
            return View(await _context.Turno.ToListAsync());
        }

        [HttpGet]
        public  IActionResult CreatePacient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePacient(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Paciente.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Pacientes));
            }
            return View();
        }

        // busca datos del paciente por id
        [HttpGet]
        public IActionResult EditPacient(int? id)
        {
            var paciente = _context.Paciente.Find(id);

            if(paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        [HttpPost]
        public async Task<IActionResult> EditPacient(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Update(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Pacientes));
            }
            return View();
        }


        [HttpGet]
        public IActionResult Inicio()
        {
            return View();
        }


        [HttpGet]
        public IActionResult DeletePacient(int? id)
        {
            var paciente = _context.Paciente.Find(id);

            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

    }


}
