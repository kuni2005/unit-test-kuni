using NUnit.Framework;
using libreria;

namespace libreria.tests
{
    public class LibraryTests
    {
        [Test]
        public void Should_AddBook_And_FindIt()
        {
            var library = new Library();
            library.AddBook("Clean Code");

            Assert.IsTrue(library.HasBook("Clean Code"));
        }

        [Test]
        public void Should_ReturnFalse_IfBookNotExists()
        {
            var library = new Library();

            Assert.IsFalse(library.HasBook("The Pragmatic Programmer"));
        }

        [Test]
        public void Should_Allow_DuplicatedBooks()
        {
            var library = new Library();
            library.AddBook("Domain-Driven Design");
            library.AddBook("Domain-Driven Design");

            Assert.IsTrue(library.HasBook("Domain-Driven Design"));
        }
    }
}
