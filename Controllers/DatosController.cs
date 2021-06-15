using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PC4.Data;
using PC4.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace PC4.Controllers
{
 [Authorize]   
    public class DatosController : Controller
    {
       private readonly ILogger<DatosController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public DatosController(ILogger<DatosController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context=context;
            _userManager = userManager;
        }

    public IActionResult DatoUsuario(){
            return View();
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
    public IActionResult DatoUsuario([Bind("id,titulo,usuario,url_foto")]Datos d)
        {
            if(ModelState.IsValid){
                _context.Add(d);
                _context.SaveChanges();
                 Console.WriteLine("Datos enviados con éxito");
                return RedirectToAction("DatoUsuario");
            }
            return View(d);
        }
         [HttpPost]
          [ValidateAntiForgeryToken]
    public IActionResult Anonimo([Bind("id,comentario")]Anonimo c)
        {
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                 Console.WriteLine("Comentario enviado con éxito");
                return RedirectToAction("Anonimo");
            }
            return View(c);
        }
    public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var reclamos = _context.Datos.FirstOrDefault(r => r.id == id);
            _context.Remove(reclamos);
            _context.SaveChanges();
            return RedirectToAction("DatoUsuarios");
        }
        
[AllowAnonymous]
        public IActionResult DatoUsuarios()
        { 
        var datos = _context.Datos.ToList();
            return View(datos);
        }

        public IActionResult Anonimos()
        { 
        var anonimos = _context.Anonimo.ToList();
            return View(anonimos);
        }

    }
}