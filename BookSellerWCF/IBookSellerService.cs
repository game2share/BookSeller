using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookSellerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IBookSellerService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IBookSellerService
    {
        [OperationContract]
        Book getBookById(string id);
        [OperationContract]
        IEnumerable<Book> getAllBooks();
        [OperationContract]
        IEnumerable<Book> getBooksByAuthor(string author);
        [OperationContract]
        IEnumerable<Book> getBookByGenre(string genre);

    }
}
