using s1110834035_NetFinal.Models;
using System.Collections.Generic;

namespace s1110834035_NetFinal.ViewModels
{
    public class PhotographVM
    {
        public List<Albums> AlbumList { get; set; }
        public List<Photos> PhotoList { get; set; }
        public int SrhId { get; set; }
        public string SrhName { get; set; }
    }
}
