namespace libreria
{
    public class Library
    {
        private List<string> books = new();

        public void AddBook(string bookTitle)
        {
            books.Add(bookTitle);
        }

        public bool HasBook(string bookTitle)
        {
            return books.Contains(bookTitle);
        }
    }
}
