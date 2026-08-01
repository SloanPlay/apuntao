using Microsoft.AspNetCore.Mvc;
using Api.Models;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private static readonly List<Tarea> _tareas = new();
    private static int _siguienteId = 1;

    [HttpGet]
    public IActionResult GetTodas()
    {
        return Ok(_tareas);
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        var tarea = _tareas.FirstOrDefault(t => t.Id == id);

        if (tarea == null)
        {
            return NotFound();
        }

        return Ok(tarea);
    }

    [HttpPost]
    public IActionResult Crear([FromBody] Tarea tarea)
    {
        if (tarea == null || string.IsNullOrWhiteSpace(tarea.Titulo))
        {
            return BadRequest("El titulo es obligatorio.");
        }

        tarea.Id = _siguienteId++;
        _tareas.Add(tarea);

        return CreatedAtAction(nameof(GetPorId), new { id = tarea.Id }, tarea);
    }

    [HttpPut("{id}")]
    public IActionResult Actualizar(int id, [FromBody] Tarea tareaActualizada)
    {
        var tarea = _tareas.FirstOrDefault(t => t.Id == id);

        if (tarea == null)
        {
            return NotFound();
        }

        tarea.Titulo = tareaActualizada.Titulo;
        tarea.Descripcion = tareaActualizada.Descripcion;
        tarea.Completada = tareaActualizada.Completada;
        tarea.FechaLimite = tareaActualizada.FechaLimite;

        return Ok(tarea);
    }

    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        var tarea = _tareas.FirstOrDefault(t => t.Id == id);

        if (tarea == null)
        {
            return NotFound();
        }

        _tareas.Remove(tarea);

        return NoContent();
    }
}