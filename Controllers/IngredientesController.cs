using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReceitasMvc.Data;
using ReceitasMvc.DTO;
using ReceitasMvc.Models;

namespace ReceitasMvc.Controllers
{
    [Authorize(Policy = "admin")]
    public class IngredientesController : Controller
    {

        private readonly ApplicationDbContext database;
        public IngredientesController(ApplicationDbContext database)
        {
            this.database = database;
        }



        [HttpPost]
        public IActionResult Salvar(IngredienteDTO ingredienteTemporaria)
        {

            if (ModelState.IsValid)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Nome = ingredienteTemporaria.Nome;
                ingrediente.Status = true;
                database.Ingredientes.Add(ingrediente);
                database.SaveChanges();
                return RedirectToAction("Ingredientes", "Gestao");

            }
            else
            {
                return View("../Gestao/NovaIngrediente");
            }
        }
        [HttpPost]
        public IActionResult Atualizar(IngredienteDTO ingredienteTemporario)
        {

            if (ModelState.IsValid)
            {
                var ingrediente = database.Ingredientes.FirstOrDefault(ing => ing.Id == ingredienteTemporario.Id);
                ingrediente.Nome = ingredienteTemporario.Nome;
                database.SaveChanges();
                return RedirectToAction("Ingredientes", "Gestao");

            }
            else
            {
                return View("../Gestao/EditarIngrediente");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if (id > 0)
            {
                var ingrediente = database.Ingredientes.FirstOrDefault(ing => ing.Id == id);
                ingrediente.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Ingredientes", "Gestao");
        }

    }
}