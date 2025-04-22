using NUnit.Framework;
using Moq;
using libreria;

namespace libreria.tests
{
    public class LibraryTests
    {        
        [Test] // ✅ Marca este método como prueba
        public void Should_AddBook_UsingRepository()
        {
            var repoMock = new Mock<IBookRepository>();           // crear el mock de IBookRepository
            var library = new Library(repoMock.Object);           // inyecta el mock en Library

            library.AddBook("Clean Code");                        // agregar libro

            repoMock.Verify(r => r.Add("Clean Code"), Times.Once); // verificar que add fue llamado 1 vez
        }

        [Test] // ✅ Marca este método como prueba
        //  Simula que un libro sí existe, y verifica que HasBook lo reconozca
        public void Should_ReturnTrue_WhenBookExists()
        {
            var repoMock = new Mock<IBookRepository>();                         // Mock del repo
            repoMock.Setup(r => r.Exists("Refactoring")).Returns(true);        // Simula que el libro existe

            var library = new Library(repoMock.Object);                         // Inyecta el mock

            Assert.IsTrue(library.HasBook("Refactoring"));                     // Verifica que devuelve true
        }

        [Test] // ✅ Marca este método como prueba
        // Simula que un libro no existe, y verifica que HasBook devuelva false
        public void Should_ReturnFalse_WhenBookDoesNotExist()
        {
            var repoMock = new Mock<IBookRepository>();                         // Mock del repo
            repoMock.Setup(r => r.Exists("Unknown Book")).Returns(false);      // Simula que el libro no existe

            var library = new Library(repoMock.Object);                         // Inyecta el mock

            Assert.IsFalse(library.HasBook("Unknown Book"));                   // Verifica que devuelve false
        }
    }
}
