using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Test_Examen.Models;

[Route("api/[controller]")]
[ApiController]
public class SchoolController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SchoolController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("profesori")]
    public async Task<IActionResult> GetProfesori()
    {
        var profesori = await _context.Profesori.ToListAsync();//le fac asincrone ca de ce nu
        return Ok(profesori);
    }

    [HttpGet("materii")]
    public async Task<IActionResult> GetMaterii()
    {
        var materii = await _context.Materii.ToListAsync();
        return Ok(materii);
    }

    [HttpGet("profesor-materii")]
    public async Task<IActionResult> GetProfesorMaterii()
    {
        var profesorMaterii = await _context.MateriiProfesori.ToListAsync();
        return Ok(profesorMaterii);
    }


    [HttpPost("profesori")]
    public async Task<IActionResult> AddProfesor(string nume, bool laborant)
    {
        var profesor = new Profesor { Nume = nume, EsteLaborant = laborant};
        _context.Profesori.Add(profesor);
        await _context.SaveChangesAsync();
        return Ok(profesor);
    }

    [HttpPost("materii")]
    public async Task<IActionResult> AddMaterie(string nume, int credite)
    {
        var materie = new Materie { Nume = nume , Credite = credite };
        _context.Materii.Add(materie);
        await _context.SaveChangesAsync();
        return Ok(materie);
    }


    [HttpPost("asignare")]
    public async Task<IActionResult> AsignareMaterieProfesor(Profesor_Materie materieProfesor)
    {
        _context.MateriiProfesori.Add(materieProfesor);
        await _context.SaveChangesAsync();
        return Ok(materieProfesor);
    }
}