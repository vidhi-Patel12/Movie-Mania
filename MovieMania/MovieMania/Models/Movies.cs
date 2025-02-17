using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieMania.Models
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        [Required(ErrorMessage = "MovieName is required.")]
        public string? MovieName { get; set; }
        [Required(ErrorMessage = "ReleaseDate is required.")]
        public DateOnly ReleaseDate { get; set; }
        public double Movielength { get; set; }
        [Required(ErrorMessage = "MovieCertificate is required.")]
        public string MovieCertificate { get; set; }
        public string MovieImage { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public double MovieRating { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public ICollection<MovieCinema> MovieCinemas { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieLanguage> MovieLanguages { get; set; }
        public ICollection<MovieFormat> MovieFormats { get; set; }

    }
}
