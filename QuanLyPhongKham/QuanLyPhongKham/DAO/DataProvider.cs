using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    public class DataProvider
    {
        #region Singletone Parttern

        private static DataProvider instane;

        /// <summary>
        /// kiểm tra xem đã tạo đối tượng DataProvider nào trước đó hay chưa.
        /// Nếu chưa thì tạo mới, nếu có rồi thì trả về đối tượng đó lun.
        /// </summary>
        public static DataProvider Instane
        {
            get
            {
                if (instane == null)
                {
                    instane = new DataProvider();
                }
                return instane;
            }
        }


        /// <summary>
        /// private constructor để ngăn việc tạo đối tượng từ bên ngoài
        /// </summary>
        private DataProvider() { }


        #endregion

        
        #region

        /// <summary>
        /// Biến dùng để kết nối đến db
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Connection String dùng để kết nối db
        /// </summary>
        private string connectionString = @"Data Source=.;Initial Catalog=quanlyphongkham;Integrated Security=True";


        


        #endregion
    }
}
