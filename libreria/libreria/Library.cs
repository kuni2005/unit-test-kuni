namespace libreria
{
    public class Library
    {
        private readonly IBookRepository _repository; //guardamos la dependencia

        public Library(IBookRepository repository) //recibimos el repo
        {
            _repository = repository;
        }

        public void AddBook(string book) //metodo que agrega un libro usando el repo
        {
            _repository.Add(book);
        }

        public bool HasBook(string book) //metodo para verificar si existe un libro
        {
            return _repository.Exists(book);
        }
    }
}
