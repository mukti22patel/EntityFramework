namespace WebApplication4.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal NoOfPages { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int CountryId { get; set; }
    }
}
