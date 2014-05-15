using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookSellerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "BookSellerService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez BookSellerService.svc ou BookSellerService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class BookSellerService : IBookSellerService
    {
        List<Book> bookList = new List<Book>();

        public BookSellerService()
        {
            bookList.Add(new Book("1234567891234", "The history of my life !", "Le Grand Martin", "Le meilleur", -50));
            bookList.Add(new Book("4242424242424", "H2G2", "Douglas Adams", "Science-fiction - Comédie", 42.00));
            bookList.Add(new Book("9780375826689", "Eragon", "Christopher Paolini", "Fantastique", 19.01));
            bookList.Add(new Book("9782747014557", "L'Ainé", "Christopher Paolini", "Fantastique", 29.01));
        }

        Book IBookSellerService.getBookById(string id)
        {
            foreach(Book book in bookList){
                if (book.Id.Equals(id))
                {
                    return book;
                }
            }
            return null;
        }

        IEnumerable<Book> IBookSellerService.getAllBooks()
        {
            return bookList;
        }

        IEnumerable<Book> IBookSellerService.getBooksByAuthor(string author)
        {
            List<Book> byAuthor = new List<Book>();
            foreach (Book book in bookList)
            {
                if (book.Author.Equals(author))
                {
                    byAuthor.Add(book);
                }
            }
            return byAuthor;
        }

        IEnumerable<Book> IBookSellerService.getBookByGenre(string genre)
        {
            List<Book> byGenre = new List<Book>();
            foreach (Book book in bookList)
            {
                if (book.Genre.Equals(genre))
                {
                    byGenre.Add(book);
                }
            }
            return byGenre;
        }
    }
}
