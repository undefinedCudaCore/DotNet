using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_1_003_Many_to_many.Models
{
    [Table("Author")]
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(150)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(150)]
        public string? LastName { get; set; }

        public IList<AuthorBlog> AuthorBlogs { get; set; } = new List<AuthorBlog>();
    }
}
