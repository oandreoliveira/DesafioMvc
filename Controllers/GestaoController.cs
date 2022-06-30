using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReceitasMvc.Data;
using ReceitasMvc.DTO;

namespace ReceitasMvc.Controllers
{
    [Authorize(Policy = "admin")]
    public class GestaoController : Controller
    {
        private readonly ApplicationDbContext database;
        public GestaoController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexID()
        {
            InsumoReceitaDTO receitas = new();
            receitas.Receitas = database.Receitas.Where(r => r.Status == true).ToList(); // instanciando a lista de receitas no DTO


            ViewBag.Medidas = database.Medidas.ToList();
            ViewBag.Ingredientes = database.Ingredientes.ToList();

            return View(receitas); //para poder receber a lista
        }
        public IActionResult Categorias()
        {
            var categorias = database.Categorias.Where(cat => cat.Status == true).ToList();
            return View(categorias);
        }
        public IActionResult NovaCategoria()
        {
            return View();
        }

        public IActionResult EditarCategoria(int id)
        {
            var categoria = database.Categorias.FirstOrDefault(cat => cat.Id == id);
            CategoriaDTO categoriaView = new CategoriaDTO();
            categoriaView.Id = categoria.Id;
            categoriaView.Nome = categoria.Nome;
            return View(categoriaView);
        }

        //--------------------------------------------------------------------------------------------
        public IActionResult Ingredientes()
        {
            var ingredientes = database.Ingredientes.Where(ing => ing.Status == true).ToList();
            return View(ingredientes);
        }
        public IActionResult NovoIngrediente()
        {
            return View();
        }
        public IActionResult EditarIngrediente(int id)
        {
            var ingrediente = database.Ingredientes.FirstOrDefault(ing => ing.Id == id);
            IngredienteDTO ingredienteView = new IngredienteDTO();
            ingredienteView.Id = ingrediente.Id;
            ingredienteView.Nome = ingrediente.Nome;
            return View(ingredienteView);
        }


        //--------------------------------------------------------------------------------------------
        public IActionResult Medidas()
        {
            var medidas = database.Medidas.Where(med => med.Status == true).ToList();
            return View(medidas);
        }
        public IActionResult NovaMedida()
        {
            return View();
        }
        public IActionResult EditarMedida(int id)
        {
            var medida = database.Medidas.First(m => m.Id == id);
            MedidaDTO medidaView = new MedidaDTO();
            medidaView.Id = medida.Id;
            medidaView.Nome = medida.Nome;
            return View(medidaView);
        }
        //--------------------------------------------------------------------------------------------
        public IActionResult Receitas()
        {
            var receitas = database.Receitas.Where(p => p.Status == true).Include(p => p.Categoria).Where(p => p.Status == true).ToList();
            return View(receitas);

        }
        public IActionResult NovaReceita()
        {
            ViewBag.Categorias = database.Categorias.ToList();
            return View();
        }
        public IActionResult EditarReceita(int id)
        {
            var receita = database.Receitas.Include(p => p.Categoria).FirstOrDefault(r => r.Id == id);
            ReceitaDTO receitaView = new ReceitaDTO();
            receitaView.Id = receita.Id;
            receitaView.Nome = receita.Nome;
            receitaView.CategoriaID = receita.Categoria.Id;
            receitaView.ModoDePreparo = receita.ModoDePreparo;
            receitaView.TempoDePreparo = receita.TempoDePreparo;
            receitaView.Porcao = receita.Porcao;
            ViewBag.Categorias = database.Categorias.ToList();

            return View(receitaView);
        }



        //--------------------------------------------------------------------------------------------


        public IActionResult ReceitaFinal(int id) // vizualizar receita por id
        {
            var receitafinal = database.InsumoReceitas.Include(p => p.Receita).Where(p => p.Receita.Id == id).Where(p => p.Receita.Status == true).ToList();
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Ingrediente = database.Ingredientes.ToList();
            ViewBag.Medida = database.Medidas.ToList();
            return View(receitafinal);

        }
        public IActionResult ReceitasID()
        {
            var receitas = database.Receitas.Where(p => p.Status == true).Include(p => p.Categoria).Where(p => p.Status == true).ToList();
            return View(receitas);

        }


    }
}