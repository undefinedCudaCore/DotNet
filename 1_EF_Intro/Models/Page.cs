using System.ComponentModel.DataAnnotations.Schema;

namespace _1_EF_Intro.Models
{
    internal class Page
    {
        public Page(int number, string content)
        {
            Number = number;
            Content = content;
        }

        public int PageId { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
        public DateTime PublishTime { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
