using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReceitasMvc.Data;
using ReceitasMvc.DTO;
using ReceitasMvc.Models;


namespace ReceitasMvc.Controllers
{
    [Authorize(Policy = "admin")]
    public class ReceitasController : Controller
    {
        private readonly ApplicationDbContext database;
        public ReceitasController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Salvar(ReceitaDTO ReceitaTemporaria)
        {
            if (ModelState.IsValid)
            {
                Receita receita = new Receita();
                receita.Nome = ReceitaTemporaria.Nome;
                receita.Foto = ReceitaTemporaria.Foto;
                receita.Categoria = database.Categorias.First(categoria => categoria.Id == ReceitaTemporaria.CategoriaID);
                receita.ModoDePreparo = ReceitaTemporaria.ModoDePreparo;
                receita.TempoDePreparo = ReceitaTemporaria.TempoDePreparo;
                receita.Porcao = ReceitaTemporaria.Porcao;
                receita.Status = true;
                database.Receitas.Add(receita);
                database.SaveChanges();
                // ViewData["teste"] = database.Receitas.OrderBy(p => p.Id).Last().Id;
                return RedirectToAction("IndexID", "Gestao");

            }
            else
            {

                ViewBag.Categorias = database.Categorias.ToList();
                return View("../Gestao/NovaReceita");
            }

        }
        [HttpPost]
        public IActionResult Atualizar(ReceitaDTO receitaTemporaria)
        {

            if (ModelState.IsValid)
            {
                var receita = database.Receitas.FirstOrDefault(prod => prod.Id == receitaTemporaria.Id);
                receita.Nome = receitaTemporaria.Nome;
                receita.Foto = receitaTemporaria.Foto;
                receita.Categoria = database.Categorias.FirstOrDefault(categoria => categoria.Id == receitaTemporaria.CategoriaID);
                receita.ModoDePreparo = receitaTemporaria.ModoDePreparo;
                receita.TempoDePreparo = receitaTemporaria.TempoDePreparo;
                receita.Porcao = receitaTemporaria.Porcao;

                database.SaveChanges();
                return RedirectToAction("Receitas", "Gestao");

            }
            else
            {
                return View("../Gestao/EditarReceita");
            }
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            if (id > 0)
            {
                var receita = database.Receitas.First(p => p.Id == id);
                receita.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Receitas", "Gestao");

        }

        public IActionResult CancelarReceita() // Cancelar na hora dos Insumos
        {
            {
                var receita = database.Receitas.OrderBy(p => p.Id).Last();

                receita.Status = false;
                database.SaveChanges();
            }
            return RedirectToAction("Receitas", "Gestao");

        }


        //-----------------------------------------------


        [HttpPost]
        public IActionResult Receita(int id) // Receita pesquisada
        {
            if (id > 0)
            {
                var receita = database.Receitas.Where(r => r.Status == true).Include(r => r.Categoria).FirstOrDefault(r => r.Id == id);
                if (receita != null)
                {
                    Response.StatusCode = 200;
                    return Json(receita);
                }
                else
                {
                    Response.StatusCode = 404;
                    return Json(null);
                }
            }
            else
            {
                Response.StatusCode = 404;
                return Json(null);
            }
        }

        [HttpPost]
        public IActionResult GerarReceita([FromBody] InsumoReceitaDTO[] dados) //recebendo a tabela (o Json)
        {
            List<InsumoReceita> insumos = new List<InsumoReceita>(); // Model, porque o banco não aceita o dto
            foreach (var item in dados) // varrer o json
            {
                var insumoReceita = new InsumoReceita(); // criando objeto
                insumoReceita.Receita = database.Receitas.FirstOrDefault(r => r.Id == item.ReceitaID); // First mas não buga
                insumoReceita.Quantidade = item.Quantidade; // diferente pq está apenas no Json
                insumoReceita.Medida = database.Medidas.FirstOrDefault(m => m.Id == item.MedidaID); ;
                insumoReceita.Ingrediente = database.Ingredientes.FirstOrDefault(i => i.Id == item.IngredienteID);

                insumos.Add(insumoReceita);
            }
            database.AddRange(insumos); // adiciona os dados da lista ao BD
            database.SaveChanges();

            return Ok(dados);


        }


    }
}