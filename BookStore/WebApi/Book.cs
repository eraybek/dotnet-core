using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Id ogesinin Auto Increment olarak DB'ye kaydedilmesini sağlar.
        public int Id { get; set; }
        public string? Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}