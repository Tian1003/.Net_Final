using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Services;
using s1110834035_NetFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace s1110834035_NetFinal.Controllers
{
    public class NetFinalController : Controller
    {
        //private readonly AppDbContext _db;
        private readonly DrinkDBService ImgCarService = new DrinkDBService();
        public NetFinalController(AppDbContext db)
        {
            //_db = db;
            ImgCarService._dbS = db;
        }
        public IActionResult Index()
        {
            //宣告 ViewModel 的物件
            ImgIndexVM Data = new ImgIndexVM();
            //呼叫 Service 的服務, 將回傳的結果指派給ViewModel
            Data.ImgList = ImgCarService.GetImgList();

            Data.ProductList = ImgCarService.GetProductList();
            //傳遞給View
            return View(Data);
        }
    }
}
