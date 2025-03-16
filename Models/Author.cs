namespace ExplictLoadingInAspNetCoreWebapi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
