using LaMiaPizzeriaModel.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using LaMiaPizzeriaModel.Models;
namespace LaMiaPizzeriaModel.Controllers
{
    public class PizzeController : Controller
    {
        public IActionResult PizzeIndex()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Pizza> listaDeiPost = DataPizza.GetPizze();

            return View("Index", listaDeiPost);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listaDellePizze = DataPizza.GetPizze();

            foreach (Pizza pizza in listaDellePizze)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("Il post con l'id cercato non esiste!");
        }



    }
}
