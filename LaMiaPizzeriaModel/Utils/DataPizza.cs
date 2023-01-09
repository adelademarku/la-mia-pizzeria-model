using Microsoft.Extensions.Hosting;
using LaMiaPizzeriaModel.Models;

namespace LaMiaPizzeriaModel.Utils
{
    public static class DataPizza
    {
        private static List<Pizza> pizze;

        public static List<Pizza> GetPizze()
        {

            if (pizze != null)
            {
                return pizze;
            }

            pizze = new List<Pizza>();

            for (int i = 0; i < 10; i++)
            {
                Pizza postGenerato = new Pizza(i, "Titolo post: " + i, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "https://picsum.photos/id/" + i + "/300");
                pizze.Add(postGenerato);
            }
            return pizze;

        }
    }
}
