using s1110834035_NetFinal.Data;
using s1110834035_NetFinal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace s1110834035_NetFinal.Services
{
    public class DrinkDBService
    {
        public AppDbContext _dbS;
        public List<ImgCarousel> GetImgList()
        {
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
    }
}
