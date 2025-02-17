namespace MovieMania.Models
{
    public class MovieFormat
    {
        public int MovieFormatId { get; set; }
        public int MovieId { get; set; }
        public int FormatId { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public Movies Movie { get; set; }
        public Formats Format { get; set; }
    }
}
