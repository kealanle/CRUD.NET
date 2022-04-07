using System.ComponentModel.DataAnnotations;

namespace CRUDweb.Models;

public class Planta
{
    [Key]
    public int Id { get; set; }

    public string Ubicacion { get; set; } = string.Empty;

    //Navigation Properties
    public Cliente? Cliente { get; set; }
    public int ClienteId { get; set; }

    public List<Equipo>? Equipos { get; set; }



}

