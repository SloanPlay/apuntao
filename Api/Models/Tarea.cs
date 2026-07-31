namespace Api.Models;

// TODO: Agregar las propiedades que describen una tarea.
// Ejemplo de propiedades que podrian ir:
//   - Id (int)
//   - Titulo (string)
//   - Descripcion (string, puede ser null)
//   - Completada (bool)
//   - FechaCreacion (DateTime)
//   - FechaLimite (DateTime, puede ser null)
//
// Tip: Si la propiedad puede ser nula, usar "?" (ej: string? Descripcion)

public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public bool Completada { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public DateTime? FechaLimite { get; set; }
}
