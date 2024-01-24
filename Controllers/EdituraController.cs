using Microsoft.AspNetCore.Mvc;
using Test_Examen.ContextModels;
using Test_Examen.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class EdituriController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EdituriController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Edituri
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Editura>>> GetEdituri()
    {
        return await _context.Edituri.ToListAsync();
    }

    // GET: api/Edituri/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Editura>> GetEditura(int id)
    {
        var editura = await _context.Edituri.FindAsync(id);

        if (editura == null)
        {
            return NotFound();
        }

        return editura;
    }

    // Additional methods (POST, PUT, DELETE) as needed
}