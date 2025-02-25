namespace Soheil_Imani_EntityFramework_Project.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
