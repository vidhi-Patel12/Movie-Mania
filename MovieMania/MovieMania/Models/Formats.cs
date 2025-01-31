using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMania.Models
{
    public class Formats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int FormatId { get; set; }
        [Required]
        public string? FormatName { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
