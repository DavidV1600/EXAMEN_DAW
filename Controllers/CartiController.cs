using Microsoft.AspNetCore.Mvc;
using Test_Examen.ContextModels;
using Test_Examen.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class CartiController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CartiController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Carti
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Carte>>> GetCarti()
    {
        return await _context.Carti
            .Include(c => c.Autor)
            .Include(c => c.Editura)
            .ToListAsync();
    }

    // GET: api/Carti/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Carte>> GetCarte(int id)
    {
        var carte = await _context.Carti
            .Include(c => c.Autor)
            .Include(c => c.Editura)
            .FirstOrDefaultAsync(c => c.CarteId == id);

        if (carte == null)
        {
            return NotFound();
        }

        return carte;
    }

    // Additional methods (POST, PUT, DELETE) as needed
}