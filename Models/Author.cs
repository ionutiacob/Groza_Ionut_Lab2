using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Groza_Ionut_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Firstname")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [DisplayName("Author")]
        public string FullName { get { return FirstName + LastName; } }
        public ICollection<Book>? Books { get; set; }
    }
}
