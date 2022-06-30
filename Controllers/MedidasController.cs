using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReceitasMvc.Data;
using ReceitasMvc.DTO;
using ReceitasMvc.Models;
namespace ReceitasMvc.Controllers
{
    [Authorize(Policy = "admin")]
    public class MedidasController : Controller
    {
        private readonly ApplicationDbContext database;
        public MedidasController(ApplicationDbContext database)
        {
            this.database = database;
        }



        [HttpPost]
        public IActionResult Salvar(MedidaDTO medidaTemporaria)
        {

            if (ModelState.IsValid)
            {
                Medida medida = new Medida();
                medida.Nome = medidaTemporaria.Nome;
                medida.Status = true;
                database.Medidas.Add(medida);
                database.SaveChanges();
                return RedirectToAction("Medidas", "Gestao");

            }
            else
            {
                return View("../Gestao/NovaMedida");
            }
        }
        [HttpPost]
        public IActionResult Atualizar(MedidaDTO medidaTemporaria)
        {

            if (ModelState.IsValid)
            {
                var medida = database.Medidas.FirstOrDefault(m => m.Id == medidaTemporaria.Id);
                medida.Nome = medidaTemporaria.Nome;
                database.SaveChanges();
                return RedirectToAction("Medidas", "Gestao");

            }
            else
            {
                return View("../Gestao/EditarMedida");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if (id > 0)
            {
                var medida = database.Medidas.FirstOrDefault(m => m.Id == id);
                medida.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Medidas", "Gestao");
        }

    }
}