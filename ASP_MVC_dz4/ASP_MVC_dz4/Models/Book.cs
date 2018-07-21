using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_dz4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public Publisher Publisher = new Publisher();
        public IEnumerable<Author> Authors { get; set; }
        public void AddAuthor(Author author) {
            Authors = Authors.Add(author);
        }
        public void DeleteAuthor(int id)
        {
            Authors = Authors.Delete(id);
        }
        //public List<Author> Authors { get; set; }
    }
}