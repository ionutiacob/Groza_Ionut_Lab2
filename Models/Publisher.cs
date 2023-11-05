using System.ComponentModel;

namespace Groza_Ionut_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [DisplayName("Publisher")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
