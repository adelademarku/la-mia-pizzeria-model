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
            List<Pizza> listaDellePizze = DataPizza.GetPizze();

            return View("Index", listaDellePizze);
        }

        public IActionResult PizzeIndex(int id)
        {
            List<Pizza> listaDellePizze = DataPizza.GetPizze();

            foreach (Pizza pizza in listaDellePizze)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("la pizza con l'id cercato non esiste!");
        }



    }
}
