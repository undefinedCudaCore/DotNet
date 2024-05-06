namespace _3_1_003_Many_to_many.Models
{
    internal class AuthorBlog
    {
        public int AuthorId { get; set; }
        public int BlogId { get; set; }

        public Author Author { get; set; }
        public Blog Blog { get; set; }
    }
}
