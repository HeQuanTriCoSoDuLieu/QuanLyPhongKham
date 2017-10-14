using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.BUS;
using QuanLyPhongKham.Properties;
using MetroFramework.Forms;
using QuanLyPhongKham.DAO;
namespace QuanLyPhongKham.GUI
{
    public partial class fLogin : MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// hàm load form khi khởi chạy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fLogin_Load(object sender, EventArgs e)
        {
            #region Style cho form
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            #endregion

            if (Settings.Default.RememberMe)
            {
                txbUserName.Text = Settings.Default.Username;
                txbPassWord.Text = Settings.Default.Password;
                chkRememberMe.Checked = Settings.Default.RememberMe;
            }
            txbUserName.Focus();



        }


        /// <summary>
        /// sự kiện cho button đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.Trim();
            string password = txbPassWord.Text.Trim();
            bool result = TaiKhoanBUS.Instane.Login(username, password);
            if (result)
            {
                if (chkRememberMe.Checked)
                {
                    Settings.Default.Username = txbUserName.Text;
                    Settings.Default.Password = txbPassWord.Text;
                    Settings.Default.RememberMe = chkRememberMe.Checked;
                }
                else
                {
                    Settings.Default.Username = "";
                    Settings.Default.Password = "";
                    Settings.Default.RememberMe = false;
                }

                Settings.Default.Save();
                Hide();
                fTiepNhanBenhNhan f = new fTiepNhanBenhNhan();
                f.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Thất bại.");
            }
        }


        /// <summary>
        /// Sự kiện trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
