using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    public class ScreenSeats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScreenSeatId { get; set; }
        [Required]
        public int ScreenId { get; set; }
        [Required]
        public int SeatTypeId { get; set; }
        [Required]
        public int TotalSeats { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
