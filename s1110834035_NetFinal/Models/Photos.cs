using System;
using System.ComponentModel.DataAnnotations;

namespace s1110834035_NetFinal.Models
{
    public class Photos
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(100)]
        public string PhotoName { get; set; }


        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime UploadDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string FilePath { get; set; }

        [Required]
        public int AlbumId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
