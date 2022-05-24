using Microsoft.AspNetCore.Mvc;
using ProjetoWeb2022.Models;
using System.Collections.Generic;

namespace ProjetoWeb2022.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            List<CategoriaModel> lista = new CategoriaModel().listar();
            return View(lista);
        }
    }
}
