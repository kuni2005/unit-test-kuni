namespace libreria
{
    public interface IBookRepository
    {
        void Add(string book);  //agregar libro a la repo
        bool Exists(string book); //verifica si un libro existe
    }
}
