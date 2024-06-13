using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace s1110834035_NetFinal.Services
{
    public class FlickrService
    {
        public AppDbContext _dbS;   


        public List<ImgCarousel> GetImgList(){
            //直接使用dbContext取得資料，適合簡單查詢
            /*
            List<ImgCarousel> objCategoryList = _dbS.ImgCarousels.ToList();
            return objCategoryList;
            */
            //另一種方法，建立資料庫連線，利用SQL查詢，適合複雜查詢
            //宣告連線變數
            var conn = (SqlConnection)_dbS.Database.GetDbConnection();
            //SQL 查詢語句
            string sql = @" SELECT * FROM ImgCarousels;";
            //準備回傳的結構(將表格所有資料串接成一個串列)
            List<ImgCarousel> imgList = new List<ImgCarousel>();
            try
            {
                conn.Open(); // 開啟資料庫連線
                SqlCommand cmd = new SqlCommand(sql, conn); // 執行Sql 指令
                SqlDataReader dr = cmd.ExecuteReader(); // 取得查詢的資料
                while (dr.Read()) //獲得下一筆資料, 直到沒有資料
                {
                    ImgCarousel Data = new ImgCarousel(); //宣告一個暫存單筆資料的結構
                                                          //將取得的資料存入單筆資料結構
                    Data.Id = Convert.ToInt32(dr["Id"]);
                    if (!dr["ImgF"].Equals(DBNull.Value))
                    {
                        Data.ImgF = dr["ImgF"].ToString();
                    }
                    imgList.Add(Data); //將單筆資料加入串列中
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString()); // 丟出錯誤
            }
            finally
            {
                conn.Close(); // 關閉資料庫連線
            }
            return imgList;
        }



        public List<Photos> GetPhotoList()
        {
            
            //宣告連線變數
            var conn = (SqlConnection)_dbS.Database.GetDbConnection();
            //SQL 查詢語句
            string sql = @" SELECT * FROM Photos;";
            //準備回傳的結構(將表格所有資料串接成一個串列)
            List<Photos> PhotoList = new List<Photos>();
            try
            {
                conn.Open(); // 開啟資料庫連線
                SqlCommand cmd = new SqlCommand(sql, conn); // 執行Sql 指令
                SqlDataReader dr = cmd.ExecuteReader(); // 取得查詢的資料
                while (dr.Read()) //獲得下一筆資料, 直到沒有資料
                {
                    Photos Data = new Photos(); //宣告一個暫存單筆資料的結構

                    Data.Id = Convert.ToInt32(dr["Id"]);
                    Data.PhotoName = dr["PhotoName"].ToString();

                    if (!dr["Description"].Equals(DBNull.Value))
                    {
                        Data.Description = dr["Description"].ToString();
                    }
                    if (DateTime.TryParse(dr["UploadDate"].ToString(), out DateTime uploadDate))
                    {
                        Data.UploadDate = uploadDate;
                    }
                    else
                    {
                        // 处理解析失败的情况，例如设置一个默认值
                        Data.UploadDate = DateTime.MinValue; // 或者你想要的任何默认值
                    }


                    Data.FilePath = dr["FilePath"].ToString();


                    Data.AlbumId = Convert.ToInt32(dr["AlbumId"]);
                    Data.UserId = Convert.ToInt32(dr["UserId"]);



                    PhotoList.Add(Data); //將單筆資料加入串列中
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString()); // 丟出錯誤
            }
            finally
            {
                conn.Close(); // 關閉資料庫連線
            }
            return PhotoList;
            
        }
        public List<Albums> GetAlbumsList()
        {
            //宣告連線變數
            var conn = (SqlConnection)_dbS.Database.GetDbConnection();
            //SQL 查詢語句
            string sql = @" SELECT * FROM Albums;";

            
            //準備回傳的結構(將表格所有資料串接成一個串列)
            List<Albums> albumsList = new List<Albums>();
            try
            {
                conn.Open(); // 開啟資料庫連線
                SqlCommand cmd = new SqlCommand(sql, conn); // 執行Sql 指令
                SqlDataReader dr = cmd.ExecuteReader(); // 取得查詢的資料
                while (dr.Read()) //獲得下一筆資料, 直到沒有資料
                {
                    Albums album = new Albums(); //宣告一個暫存單筆資料的結構
                    album.Id = Convert.ToInt32(dr["Id"]);
                    album.AlbumName = dr["AlbumName"].ToString();
                    album.Description = dr["Description"].ToString();
                    album.CreationDate = Convert.ToDateTime(dr["CreationDate"]);
                    album.UserId = Convert.ToInt32(dr["UserId"]);
                    album.PhotoCount = Convert.ToInt32(dr["UserId"]);
                    albumsList.Add(album); //將單筆資料加入串列中
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message.ToString()); // 丟出錯誤
            }
            finally
            {
                conn.Close(); // 關閉資料庫連線
            }
            return albumsList;
        }

        
    }
}
