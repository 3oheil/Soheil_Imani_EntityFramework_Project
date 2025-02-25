namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Wsbsite { get; set; }
        public string Country{ get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
