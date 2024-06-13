using Microsoft.AspNetCore.Mvc;
using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Models;
using s1110834035_NetFinal.Services;
using s1110834035_NetFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace s1110834035_NetFinal.Controllers
{
    public class NetFinalController : Controller
    {
        private readonly AppDbContext _db;
        private readonly FlickrService ImgService;
        private readonly PhotoGraphService PhotoService;

        public NetFinalController(AppDbContext db)
        {
            _db = db;
            ImgService = new FlickrService(); // 如果需要使用 FlickrService 的話，這裡可以初始化
            PhotoService = new PhotoGraphService(_db);
        }

        public IActionResult Index()
        {
            ImgIndexVM Data = new ImgIndexVM();

            Data.ImgList = ImgService.GetImgList();
            Data.PhotoList = ImgService.GetPhotoList();

            return View(Data);
        }

        public IActionResult photograph(int cid = 1)
        {
            PhotographVM Data = new PhotographVM();

            Data.AlbumList = PhotoService.GetAlbumsList();
            Data.PhotoList = PhotoService.GetPhotosList(cid);

            Data.SrhId = cid;
            Data.SrhName = PhotoService.GetCatName(cid);

            return View(Data);
        }



        // 新增產品一開始載入頁面
        public IActionResult Create(int cid)
        {
            // 取得頁面所需資料，藉由Service 取得
            List<Albums> AlbumList = new List<Albums>();
            ViewBag.AlbumList = PhotoService.GetAlbumsList();
            ViewBag.cid = cid;

            // 這裏使用 ViewBag 將類別資料傳遞給View。
            return View();
        }


        
        // 新增產品傳入資料時的Action
        [HttpPost]
        public async Task<IActionResult> Create(Photos Data, IFormFile ImgF)
        {
            if (ImgF != null && ImgF.Length > 0)
            {
                string fileName = Path.GetFileName(ImgF.FileName);
                string pathName = Path.Combine("wwwroot/images", fileName);

                using (var stream = new FileStream(pathName, FileMode.Create))
                {
                    await ImgF.CopyToAsync(stream);
                }

                Data.FilePath = fileName;
                Data.UploadDate = DateTime.Now;
            }
            else
            {
                ModelState.AddModelError("FilePath", "請選擇一個檔案上傳。");
                // 在此可以處理檔案未上傳的錯誤情況，例如重新顯示表單
                return View(Data);
            }

            try
            {
                PhotoService.InsertPhoto(Data);
                return RedirectToAction("photograph", new { cid = Data.AlbumId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "新增照片時發生錯誤: " + ex.Message);
                // 在此可以處理插入資料庫失敗的情況，例如重新顯示表單
                return View(Data);
            }
        }












        public IActionResult Edit(int pid)
        {
            Photos Data = PhotoService.GetPhotoById(pid);

            if (Data == null)
            {
                return RedirectToAction("PhotoGraph");
            }
            else
            {
                ViewBag.PhotoList = PhotoService.GetAlbumsList();
                ViewBag.cid = Data.AlbumId;

                return View(Data);
            }
        }

        [HttpPost]
        public IActionResult Edit(Photos UpdateData, Microsoft.AspNetCore.Http.IFormFile FilePath)
        {
            if (FilePath != null)
            {
                string fileName = Path.GetFileName(FilePath.FileName).ToString();
                string pathName = "wwwroot/images/" + Path.GetFileName(FilePath.FileName).ToString();

                UpdateData.FilePath = fileName;

                using (var stream = new FileStream(pathName, FileMode.Create))
                {
                    FilePath.CopyTo(stream);
                }
            }

            PhotoService.UpdatePhoto(UpdateData);

            return RedirectToAction("photograph", new { cid = UpdateData.AlbumId });
        }

        public IActionResult Delete(int pid)
        {
            Photos Data = PhotoService.GetPhotoById(pid);

            if (Data == null)
            {
                return RedirectToAction("photoGraph");
            }
            else
            {
                return View(Data);
            }
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Photos Data)
        {
            PhotoService.DeletePhoto(Data.Id);

            return RedirectToAction("photoGraph", new { cid = Data.AlbumId });
        }








        // 新增相簿一開始載入頁面
        public IActionResult CreateAlbum(int cid)
        {
            List<Albums> AlbumList = new List<Albums>();
            ViewBag.AlbumList = PhotoService.GetAlbumsList();
            ViewBag.cid = cid;

            return View();
        }


        // 新增相簿傳入資料時的Action
        [HttpPost]
        public IActionResult CreateAlbum(Albums album)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // 設定創建日期為當前日期時間
                    album.CreationDate = DateTime.Now;

                    // 呼叫服務層的方法來插入相簿
                    PhotoService.InsertAlbum(album);

                    // 重導向到照片列表頁面
                    return RedirectToAction("photoGraph");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "新增相簿時發生錯誤: " + ex.Message);
                }
            }

            // 如果模型驗證失敗，返回相同的視圖以顯示錯誤消息和保留用戶輸入的內容
            return View(album);
        }


        public IActionResult DeleteAlbum(int id)
        {
            
                PhotoService.DeleteAlbum(id);
                return RedirectToAction("photograph");
            
            
        }
    }
}
