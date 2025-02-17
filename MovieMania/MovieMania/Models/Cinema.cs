using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMania.Models
{
    public class Cinema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaId { get; set; }
        [Required]
        public string? CinemaName { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required(ErrorMessage = "State is required.")]
        [Range(1, 10000, ErrorMessage = "Please Select State")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "City is required.")]
        [Range(1, 20000, ErrorMessage = "Please Select City")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Pincode is required.")]
        [Range(100000, 999999, ErrorMessage = "Please enter a valid pincode.")]
        public int Pincode { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
