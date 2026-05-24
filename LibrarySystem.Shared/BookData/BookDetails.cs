using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Shared.BookData
{
    public class BookDetails
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Please enter the name field.")]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Publication { get; set; }
    }
}