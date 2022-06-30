using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReceitasMvc.Data;
using ReceitasMvc.Models;


namespace ReceitasMvc.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext database;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext database)
        {
            _logger = logger;
            this.database = database;
        }


        public IActionResult Index() // Home page
        {
            var receitafinal = database.InsumoReceitas.Include(p => p.Receita).Where(p => p.Receita.Status == true).ToList();
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Ingrediente = database.Ingredientes.ToList();
            ViewBag.Medida = database.Medidas.ToList();

            return View(receitafinal);

        }
        public IActionResult ReceitaFinalUser(int id) // vizualizar receita por id Usuário
        {
            var receitafinal = database.InsumoReceitas.Include(p => p.Receita).Where(p => p.Receita.Id == id).Where(p => p.Receita.Status == true).ToList();
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Ingrediente = database.Ingredientes.ToList();
            ViewBag.Medida = database.Medidas.ToList();
            return View(receitafinal);

        }
        public IActionResult ListaDeReceitas() // Botão listar receita
        {
            var receitas = database.Receitas.Where(p => p.Status == true).Include(p => p.Categoria).Where(p => p.Status == true).ToList();
            return View(receitas);

        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
