using System.ComponentModel.DataAnnotations;
namespace s1110834035_NetFinal.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        public string ImgF { get; set; }
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}

