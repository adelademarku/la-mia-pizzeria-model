namespace LaMiaPizzeriaModel.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Prezzo { get; set; }

        public Pizza(int id, string title, string description, string image, int prezzo)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Prezzo = prezzo;
        }
    }
}
