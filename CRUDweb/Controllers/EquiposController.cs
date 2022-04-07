using CRUDweb.Data;
using CRUDweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDweb.Controllers;


public class EquiposController : Controller
{
    private readonly AppDbContext _db;
    public EquiposController(AppDbContext db)
    {
        _db = db;

    }
    public IActionResult Index()
    {
        IEnumerable<Equipo> objEquiposList = _db.Equipos.ToList();
        return View(objEquiposList);
    }
    //Get
    public IActionResult Create()
    {
        var PlantasList = (from Planta in _db.Plantas
                          select new SelectListItem()
                          {
                              
                              Value = Planta.Id.ToString(),
                          }).ToList();
        PlantasList.Insert(0, new SelectListItem()
        {
            Text = "----Select----",
            Value = string.Empty
        });



        ViewBag.ListofPlantas = PlantasList;
       
        return View();
    }
}
