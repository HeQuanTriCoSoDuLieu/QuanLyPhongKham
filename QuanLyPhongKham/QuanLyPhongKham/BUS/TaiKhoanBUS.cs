using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.DAO;
namespace QuanLyPhongKham.BUS
{
    public class TaiKhoanBUS
    {
        #region Singletone

        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instane
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanBUS();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private TaiKhoanBUS() { }

        #endregion


        public bool Login(string username, string password)
        {
            return TaiKhoanDAO.Instane.Login(username, password);
        }

    }
}
