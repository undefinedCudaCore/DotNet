using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_1_003_Many_to_many.Models
{
    [Table("Post")]
    internal class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }

        // One to many relationship
        // Fizinis navigational property, kuris rodo kur SQL guli musu navigacinis property
        public int BlogId { get; set; }
        //Navigacinis relationship property (Naudojamas, tam, kad istraukiant Post galetume lengvai prideti prie jo Blog)
        public Blog Blog { get; set; }
    }
}
