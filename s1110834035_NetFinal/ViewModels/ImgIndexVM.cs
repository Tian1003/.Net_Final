using s1110834035_NetFinal.Models;
using System.Collections.Generic;

namespace s1110834035_NetFinal.ViewModels
{
    public class ImgIndexVM
    {
        public List<ImgCarousel> ImgList { get; set; }
        public List<Photos> PhotoList { get; set; }
        public List<Albums> AlbumList { get; set; }  // 添加相簿列表

        
    }

   
}
