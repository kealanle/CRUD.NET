using System.ComponentModel.DataAnnotations;

namespace CRUDweb.Models;

public class Equipo
{
    [Key]
    public int Id { get; set; }

    public string Tipo { get; set; } = string.Empty;
    public string UltimaInspeccion { get; set; } = string.Empty;

    //Navigation Properties
    public int PlantaID { get; set; }

    public Planta? Planta { get; set; }

}
