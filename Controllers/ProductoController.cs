using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EjercicioSem11_Teoria.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjercicioSem11_Teoria.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Registro()
        {

            ViewBag.Categorias = _context.DataCategorias.Select(x => new SelectListItem(x.DescCat,x.Id.ToString()));
            
            
            return View();
        }

    [HttpPost]
    public IActionResult Registro(Producto objP)
        {

            if(ModelState.IsValid){
                _context.DataProductos.Add(objP);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");

            }else{
                return View(objP);
            }
            
            
           
        }
    }
}