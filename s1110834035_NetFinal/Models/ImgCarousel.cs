using System.ComponentModel.DataAnnotations;
namespace s1110834035_NetFinal.Models
{
    public class ImgCarousel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImgF { get; set; }
    }
}
