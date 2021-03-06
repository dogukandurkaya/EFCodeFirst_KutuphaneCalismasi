using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Entities;

namespace EF_CodeFirst.Models.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookYearOfPublication { get; set; }
        public int BookEditionNumber { get; set; }
        public int BookNumberOfPages { get; set; }
        public int BookQantity { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}