using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rasiga_Camelia_Lab2.Models
{
    public class Book
    {
        public string ID {  get; set; }
        [Display(Name ="Book Title")]
        public string Title {  get; set; }

        public string? AuthorID {  get; set; }

        public Author? Author { get; set; } //navigation property

        [Column(TypeName="decimal(6,2)")]
        public decimal Price {  get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property

    }
}
