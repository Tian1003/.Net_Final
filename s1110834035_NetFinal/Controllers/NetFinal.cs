using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Models;
using s1110834035_NetFinal.Services;
using s1110834035_NetFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace s1110834035_NetFinal.Controllers
{
    public class NetFinalController : Controller
    {
        //private readonly AppDbContext _db;
        private readonly DrinkDBService ImgCarService = new DrinkDBService();
        private readonly CatProDBService CatProService = new CatProDBService();

        public NetFinalController(AppDbContext db)
        {
            //_db = db;
            ImgCarService._dbS = db;
            CatProService._dbS = db;
;
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
        public IActionResult CatPro(int cid = 1)
        {
            //宣告 ViewModel 的物件
            CatProVM Data = new CatProVM();

            //呼叫 Service 的服務, 將回傳的結果指派給ViewModel
            Data.CategoryList = CatProService.GetCategoryList();
            Data.ProductList = CatProService.GetProductList(cid);
            Data.SrhId = cid;
            Data.SrhName = CatProService.GetCatName(cid);
            //傳遞給View
            return View(Data);
        }

        // 新增產品一開始載入頁面
        public IActionResult Create(int cid)
        {
            // 取得頁面所需資料，藉由Service 取得
            List<Category> catList = new List<Category>();
            ViewBag.catList = CatProService.GetCategoryList();
            ViewBag.cid = cid;
            // 這裏使用 ViewBag 將類別資料傳遞給View。
            return View();
        }
        // 新增產品傳入資料時的Action
        [HttpPost]
        public IActionResult Create(Product Data)
        {
            CatProService.InsertPro(Data); // 使用Service 來新增一筆資料
            return RedirectToAction("CatPro", new { cid = Data.CategoryId }); // 重新導向頁面至開始頁面
        }

        public IActionResult CatProNew(int cid = 1)
        {
            //宣告 ViewModel 的物件
            CatProVM Data = new CatProVM();
            //呼叫 Service 的服務, 將回傳的結果指派給ViewModel
            Data.CategoryList = CatProService.GetCategoryList();
            Data.ProductList = CatProService.GetProductList(cid);
            Data.SrhId = cid;
            Data.SrhName = CatProService.GetCatName(cid);
            //傳遞給View
            return View(Data);
        }

        public IActionResult Edit(int pid)
        {
            // 取得頁面所需資料，藉由Service 取得
            Product Data = CatProService.GetProById(pid);
            // 將資料傳入View中
            if (Data == null)
            {
                //若 pid 查無產品資料, 回到清單頁
            return RedirectToAction("CatProNew");
            }
            else
            {
                // 這裏使用 ViewBag 將類別資料傳遞給View。
                List<Category> catList = new List<Category>();
                ViewBag.catList = CatProService.GetCategoryList();
                ViewBag.cid = Data.CategoryId;
                //將查到的Product傳給View
                return View(Data);
            }
        }

        // 修改產品資料(傳入資料時的Action)
        [HttpPost]// 設定此Action 只接受頁面POST 資料傳入
        public IActionResult Edit(Product UpdateData, IFormFile ImgF)
        {
            if (ImgF != null)
            {
                //取得使用者上傳檔案的原始檔名
                string fileName = Path.GetFileName(ImgF.FileName).ToString();
                string pathName = "wwwroot/images/" + Path.GetFileName(ImgF.FileName).ToString();
                //將圖片存檔
                UpdateData.ImgF = fileName;
                var stream = new FileStream(pathName, FileMode.Create);
                ImgF.CopyTo(stream);
                //使用Service 來修改資料
                CatProService.UpdatePro(UpdateData);
            }
            //重新導向頁面至開始頁面
            return RedirectToAction("CatProNew", new { cid = UpdateData.CategoryId });
        }

        
        
    }
}
