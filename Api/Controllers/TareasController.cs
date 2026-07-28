using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

// TODO: Completar cada metodo con la logica correspondiente.
// Reemplazar "throw new NotImplementedException();" con el codigo real.
//
// Pistas:
//   - GET    → devolver lista o item
//   - POST   → recibir un objeto Tarea y guardarlo
//   - PUT    → recibir un id y un objeto Tarea para actualizar
//   - DELETE → recibir un id y eliminar la tarea

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTodas()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Crear()
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public IActionResult Actualizar(int id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        throw new NotImplementedException();
    }
}
