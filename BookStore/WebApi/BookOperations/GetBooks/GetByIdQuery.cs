using WebApi;
using WebApi.Common;
using WebApi.DBOperations;

namespace Webapi.BookOperations.GetBooks
{
    public class GetByIdQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public GetByIdQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BooksVm Handle()
        {
            var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();
            BooksVm vm = new BooksVm();
            vm.Title = book.Title;
            vm.Genre = ((GenreEnum)book.GenreId).ToString();
            vm.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy");
            vm.PageCount = book.PageCount;

            return vm;
        }
    }

    public class BooksVm
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}