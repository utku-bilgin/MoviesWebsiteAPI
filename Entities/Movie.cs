using Core.BaseEntities;

namespace Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string MoviePosterUrl { get; set; }
        public string MovieTrailerUrl { get; set; }
        public string? MovieUrl { get; set; }
        public string Description { get; set; }
        public string ProductionYear { get; set; }
        public string MovieDuration { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public double? ImdbRating { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
