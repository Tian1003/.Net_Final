using s1110834035_NetFinal.Models;

namespace s1110834035_NetFinal.ViewModels
{
    public class CatProVM
    {
        public int SrhId { get; set; } //記錄目前類別Id
        public string SrhName { get; set; } //記錄目前類別Name
        public List<Category> CategoryList { get; set; } //記錄所有類別清單
        public List<Product> ProductList { get; set; } //記錄目前類別之下的所有產品清單

    }
}
