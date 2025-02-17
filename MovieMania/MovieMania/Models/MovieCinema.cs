namespace MovieMania.Models
{
    public class MovieCinema
    {
        public int MovieCinemaId { get; set; }
        public int MovieId { get; set; }
        public int CinemaId { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public Movies Movie { get; set; }
        public Cinema Cinema { get; set; }
    }
}
