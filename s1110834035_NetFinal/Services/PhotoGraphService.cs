using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace s1110834035_NetFinal.Services
{
    public class PhotoGraphService
    {
        public AppDbContext _dbS;

        // Constructor to inject AppDbContext
        public PhotoGraphService(AppDbContext db)
        {
            _dbS = db;
        }

        // Method to get list of albums
        public List<Albums> GetAlbumsList()
        {
            try
            {
                return _dbS.Albums.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving albums: " + ex.Message);
            }
        }

        // Method to get list of photos by album Id
        public List<Photos> GetPhotosList(int cid)
        {
            try
            {
                return _dbS.Photos.Where(p => p.AlbumId == cid).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving photos: " + ex.Message);
            }
        }


        // Method to get album name by Id
        public string GetCatName(int cid)
        {
            try
            {
                var album = _dbS.Albums.Find(cid);
                return album != null ? album.AlbumName : "";
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving album name: " + ex.Message);
            }
        }

        // Method to insert a new photo
        public void InsertPhoto(Photos newData)
        {
            if (string.IsNullOrEmpty(newData.FilePath))
            {
                throw new ArgumentException("FilePath cannot be null or empty");
            }

            try
            {
                string sql = "INSERT INTO Photos (PhotoName, Description, FilePath, UploadDate, UserId, AlbumId) " +
                             "VALUES (@PhotoName, @Description, @FilePath, @UploadDate, @UserId, @AlbumId)";

                using (var conn = (SqlConnection)_dbS.Database.GetDbConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PhotoName", newData.PhotoName);
                        cmd.Parameters.AddWithValue("@Description", newData.Description);
                        cmd.Parameters.AddWithValue("@FilePath", newData.FilePath);
                        cmd.Parameters.AddWithValue("@UploadDate", newData.UploadDate);
                        cmd.Parameters.AddWithValue("@UserId", newData.UserId);
                        cmd.Parameters.AddWithValue("@AlbumId", newData.AlbumId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            throw new Exception("新增照片時未成功插入資料庫");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("新增照片時發生錯誤: " + ex.Message);
            }
        }



        private DateTime EnsureValidUploadDate(DateTime uploadDate)
        {
            // Ensure the uploadDate is within SQL Server's valid range
            DateTime minSqlDateTime = new DateTime(1753, 1, 1);
            DateTime maxSqlDateTime = new DateTime(9999, 12, 31, 23, 59, 59);

            if (uploadDate < minSqlDateTime)
            {
                return minSqlDateTime;
            }
            else if (uploadDate > maxSqlDateTime)
            {
                return maxSqlDateTime;
            }
            else
            {
                return uploadDate;
            }
        }





        // Method to get photo by Id
        public Photos GetPhotoById(int pid)
        {
            try
            {
                return _dbS.Photos.Find(pid);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving photo: " + ex.Message);
            }
        }

        // Method to update photo details
        public void UpdatePhoto(Photos UpdateData)
        {
            try
            {
                var photo = _dbS.Photos.Find(UpdateData.Id);
                if (photo != null)
                {
                    photo.PhotoName = UpdateData.PhotoName;
                    photo.Description = UpdateData.Description;
                    photo.FilePath = UpdateData.FilePath;
                    photo.AlbumId = UpdateData.AlbumId;
                    _dbS.SaveChanges();
                }
                else
                {
                    throw new Exception("Photo not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating photo: " + ex.Message);
            }
        }

        // Method to delete photo by Id
        public void DeletePhoto(int pid)
        {
            try
            {
                var photo = _dbS.Photos.Find(pid);
                if (photo != null)
                {
                    _dbS.Photos.Remove(photo);
                    _dbS.SaveChanges();
                }
                else
                {
                    throw new Exception("Photo not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting photo: " + ex.Message);
            }
        }

        // Method to insert a new album
        public void InsertAlbum(Albums newAlbum)
        {
            try
            {
                newAlbum.CreationDate = DateTime.Now; // 設定創建日期為當前日期時間
                _dbS.Albums.Add(newAlbum); // 將相簿新增至資料庫上下文
                _dbS.SaveChanges(); // 儲存異動
            }
            catch (Exception ex)
            {
                throw new Exception("新增相簿時發生錯誤: " + ex.Message);
            }
        }

        public void DeleteAlbum(int pid)
        {
            try
            {
                var albums = _dbS.Albums.Find(pid);
                if (albums != null)
                {
                    _dbS.Albums.Remove(albums);
                    _dbS.SaveChanges();
                }
                else
                {
                    throw new Exception("Photo not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting photo: " + ex.Message);
            }
        }


    }
}
