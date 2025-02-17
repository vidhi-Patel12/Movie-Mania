namespace MovieMania.Models
{
    public class MovieGenre
    {
        public int MovieGenreId { get; set; }
        public int MovieId { get; set; }
        public int GenresId { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public Movies Movie { get; set; }
        public Genres Genre { get; set; }
    }
}
