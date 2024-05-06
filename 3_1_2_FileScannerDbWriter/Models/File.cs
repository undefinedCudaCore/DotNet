using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3_1_2_FileScannerDbWriter.Models
{
    [Table("File")]
    internal class File
    {
        [Key]
        public Guid FileId { get; set; }

        [MaxLength(150)]
        [Required]
        public string FileName { get; set; }

        [MaxLength(150)]
        public string? Length { get; set; }
        public string FullPath { get; set; }
    }
}
