﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Groza_Ionut_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DisplayName("Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? AuthorID { get; set; }

        [DisplayName("Author")]
        public Author? Author { get; set; }

        public int? PublisherID { get; set; }

        public Publisher? Publisher { get; set; }

        [DisplayName("Category")]
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
