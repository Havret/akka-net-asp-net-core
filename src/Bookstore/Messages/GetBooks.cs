namespace Bookstore.Messages
{
    public class GetBooks
    {
        private GetBooks() { }
        public static GetBooks Instance { get; } = new GetBooks();
    }
}