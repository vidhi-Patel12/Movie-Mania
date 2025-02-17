using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    public class MovieScreen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieScreenId { get; set; }
        [Required]
        public int CinemaId { get; set; }
        [Required]
        public int ScreenId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public TimeOnly StartTime { get; set; }
        [Required]
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public Movies Movie { get; set; }
    }
}
