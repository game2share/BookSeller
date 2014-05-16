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
            bookList.Add(new Book("1234567891234", "The history of my life !", "Le Grand Martin", "Le meilleur", 1000, 1000));
            bookList.Add(new Book("4242424242424", "H2G2", "Douglas Adams", "Science-fiction - Comédie", 42.00, 500));
            bookList.Add(new Book("9780375826689", "Eragon", "Christopher Paolini", "Fantastique", 19.9, 3));
            bookList.Add(new Book("9782747014557", "L'Ainé", "Christopher Paolini", "Fantastique", 19.9, 1));
            bookList.Add(new Book("1234567891234", "The history of my life !", "Le Grand Martin", "Le meilleur", 1000, 1000));
            bookList.Add(new Book("1111111111111", "The hobbit", "Tolkien", "Fantastique", 42.00, 500));
            bookList.Add(new Book("2222222222222", "The Lord Of The Ring I", "Tolkien", "Fantastique", 31, 3));
            bookList.Add(new Book("3333333333333", "The Lord Of The Ring II", "Tolkien", "Fantastique", 31, 1));
            bookList.Add(new Book("4444444444444", "The Lord Of The Ring III", "Tolkien", "Fantastique", 40, 1000));
            bookList.Add(new Book("5555555555555", "H2G2", "Douglas Adams", "Fantastique", 42.00, 500));
            bookList.Add(new Book("6666666666666", "Brisingr", "Christopher Paolini", "Fantastique", 30, 3));
            bookList.Add(new Book("7777777777777", "L'Héritage", "Christopher Paolini", "Fantastique", 30, 0));
            bookList.Add(new Book("8888888888888", " Des nœuds d'acier", "Sandrine Collette", "Policier", 30, 0));
            bookList.Add(new Book("9999999999999", "Arab jazz", "Karim Miské", "Policier", 30, 0));
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

        int  IBookSellerService.takeBooks(string theBook, int nb)
        {
            for (int i = 0; bookList[i].Id != theBook; i++ ){
                    if (bookList[i].Stock >= nb)
                    {
                        bookList[i].Stock -= nb;
                    }
                    return bookList[i].Stock - nb;
                }
            return -1;
        }
    }
}
