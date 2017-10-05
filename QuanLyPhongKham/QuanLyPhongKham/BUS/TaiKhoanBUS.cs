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

        private static TaiKhoanBUS instane;

        public static TaiKhoanBUS Instane
        {
            get
            {
                if (instane == null)
                {
                    instane = new TaiKhoanBUS();
                }
                return instane;
            }
            private set => instane = value;
        }
        private TaiKhoanBUS() { }

        #endregion


        public bool Login(string username, string password)
        {
            return TaiKhoanDAO.Instane.Login(username,password);
        }

    }
}
