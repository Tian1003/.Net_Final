using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace s1110834035_NetFinal.Models
{
    public class Albums
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string AlbumName { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public int UserId { get; set; }

        // 新添加的属性：照片数量
       public int PhotoCount { get; set; }

        // 导航属性，用于与照片关联
       
    }
}
