
namespace CRUDweb.Models;

    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; } =String.Empty;

        public List<Planta>? Plantas { get; set; }
}

