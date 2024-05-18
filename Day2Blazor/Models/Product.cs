using System.ComponentModel.DataAnnotations;

namespace Day2Blazor.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Must be longer than 3 characters and less than 20 characters")]
        public string? Name { get; set; }

        [Range(100_000, 10_000_000)]
        public decimal Price { get; set; }

        [Required]
        public string? DriveType { get; set; }

        [Required]
        public string? Category { get; set; }


        public int CategoryId { get; set; }
    }
}
