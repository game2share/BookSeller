using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookSellerWCF
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Title { get; private set; }
        [DataMember]
        public string Author { get; private set; }
        [DataMember]
        public string Id { get; private set; }
        [DataMember]
        public string Genre { get; private set; }
        [DataMember]
        public double Price { get; private set; }
        [DataMember]
        public int Stock { get; set; }
        public Book(string id, string title, string author, string genre, double price, int stock)
        {
            Title = title;
            Id = id;
            Author = author;
            Genre = genre;
            Price = price;
            Stock = stock;
        }

    }
}