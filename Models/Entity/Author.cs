namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName{ get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
