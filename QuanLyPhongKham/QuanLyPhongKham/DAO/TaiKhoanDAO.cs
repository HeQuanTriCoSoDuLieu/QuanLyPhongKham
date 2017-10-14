using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO
{
    public class TaiKhoanDAO
    {
        #region Singletone

        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instane
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }

        }

        private TaiKhoanDAO() { }


        #endregion

        public bool Login(string username, string password)
        {
            int result = DataProvider.Instane.ExecuteScalar("EXEC dbo.USP_LOGIN  @username , @password ", new object[] { username, password });
            return result > 0;
        }


    }
}
