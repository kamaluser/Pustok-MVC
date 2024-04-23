namespace Pustok_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPercent { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public Boolean StockStatus { get; set; }
        public List<BookImage> BookImages { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public List<BookTag> BookTags { get; set; }
    }
}
