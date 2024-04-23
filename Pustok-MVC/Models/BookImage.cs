namespace Pustok_MVC.Models
{
    public class BookImage
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public Boolean PosterStatus { get; set; }
        public Book Book { get; set; }
    }
}
