using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Repository.Models
{
    public class Book : BaseEntity
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MinLength(5)]
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Publication { get; set; }
        public string? Category { get; set; }
        public string? Edition { get; set; }
        public string? Year { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public string? PublishedYear { get; set; }
        public string? Isbn { get; set; }
        public int NoOfPages { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public string? LocationInLibrary { get; set; }

    }
}