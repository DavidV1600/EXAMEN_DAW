using Microsoft.AspNetCore.Mvc;
using Test_Examen.ContextModels;
using Test_Examen.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class AutoriController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AutoriController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Autor>>> GetAutori()
    {
        return await _context.Autori.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Autor>> GetAutor(int id)
    {
        var autor = await _context.Autori.FindAsync(id);

        if (autor == null)
        {
            return NotFound();
        }

        return autor;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAutor(int id)
    {
        var autor = await _context.Autori.FindAsync(id);
        if (autor == null)
        {
            return NotFound();
        }

        _context.Autori.Remove(autor);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}