using CRUDweb.Data;
using CRUDweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDweb.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _db;
        public ClienteController(AppDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Cliente> objClienteList = _db.Clientes.ToList();
            return View(objClienteList);
        }

        //Get
        public IActionResult Create()
        {
            
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Cliente obj)
        {
            
            if(ModelState.IsValid)
            {
                _db.Clientes.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
       
        /// ///
       
        //Edit
        public IActionResult Edit(int? Id)
        {

            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var ClienteFromDb = _db.Clientes.Find(Id);
            if (ClienteFromDb == null)
            {
                return NotFound();
            }
            return View(ClienteFromDb);
        }


        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente obj)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            return View(obj);
        }

   
        /// ///////////////////////////
      
        //Delete


        public IActionResult Delete(int? Id)
        {

            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var ClienteFromDb = _db.Clientes.Find(Id);
            if (ClienteFromDb == null)
            {
                return NotFound();
            }
            return View(ClienteFromDb);
        }
        //Post
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? Id)
        {
            var obj = _db.Clientes.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Clientes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        


    }
}
