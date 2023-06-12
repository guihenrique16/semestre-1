using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer_MVC.Infra;
using Projeto_Gamer_MVC.Models;

namespace Projeto_Gamer_MVC.Controllers
{
    [Route("[controller]")]
    public class EquipesController : Controller
    {
        private readonly ILogger<EquipesController> _logger;

        public EquipesController(ILogger<EquipesController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]// http://localhost/Equipes/Listar
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            // mochila 
            ViewBag.Equipes = c.Equipes.ToList();

            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipes novaEquipe = new Equipes();


            novaEquipe.Nome = form["nome"].ToString();

            /* Vem como string, precisamos da imagem */
            /* novaEquipe.Imagem = form["Imagem"].ToString(); */

            /* Aqui começa a logica de update de imagem */

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            //fim da lógica de upload de imagem

            c.Equipes.Add(novaEquipe);//c.Add(novaEquipe);
            c.SaveChanges();

            return LocalRedirect("~/Equipes/Listar");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Equipes e = c.Equipes.First(e => e.IdEquipes == id);

            c.Equipes.Remove(e);


            return LocalRedirect("~/Equipes/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            Equipes e = c.Equipes.First(e => e.IdEquipes == id);

            ViewBag.Equipes = e;

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form, Equipes e)
        {
            Equipes novaEquipe = new Equipes();

            novaEquipe.Nome = e.Nome;

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }

            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            Equipes equipe = c.Equipes.First(x => x.IdEquipes == e.IdEquipes);

            equipe.Nome = novaEquipe.Nome;
            equipe.Imagem = novaEquipe.Imagem;

            c.Equipes.Update(equipe);

            c.SaveChanges();

            return LocalRedirect("~/Equipes/Listar");


        }
    }




}