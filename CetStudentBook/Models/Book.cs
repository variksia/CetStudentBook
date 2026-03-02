using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 200 characters.")]
        [DisplayName("Book Title")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author is required.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Author must be between 2 and 200 characters.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Publish Date is required.")]
        [DataType(DataType.Date)]
        [DisplayName("Publish Date")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Page Count is required.")]
        [Range(1, 10000, ErrorMessage = "Page Count must be between 1 and 10000.")]
        [DisplayName("Page Count")]
        public int PageCount { get; set; }

        [Required(ErrorMessage = "Is Second Hand is required.")]
        [DisplayName("Second Hand?")]
        public bool IsSecondHand { get; set; }
    }
}
