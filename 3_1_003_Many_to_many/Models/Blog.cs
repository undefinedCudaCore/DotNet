using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_1_003_Many_to_many.Models
{
    [Table("Blog")]
    internal class Blog
    {
        [Key]
        [Column(Order = 0)]
        public int BlogId { get; set; }

        [Column(Order = 2)]
        public decimal Rating { get; set; }

        [Column("BlogName", Order = 1)]
        public string Name { get; set; }

        public IList<Post> Posts { get; set; }
        public IList<AuthorBlog> AuthorBlogs { get; set; } = new List<AuthorBlog>();
    }
}
