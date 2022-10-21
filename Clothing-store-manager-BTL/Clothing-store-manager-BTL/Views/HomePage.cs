using Clothing_store_manager_BTL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_store_manager_BTL.Views
{
    public partial class HomePage : Form
    {
        ConnectionToSQL connection; 
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            connection = new ConnectionToSQL();
            string s1 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory().ToString() + "\\DataBase\\" + "QLCuaHangQuanAo.mdf; Integrated Security = True";
            string s2 = "Data Source=TungNhe;Initial Catalog=QLCuaHangQuanAo;Integrated Security=True";
            try
            {
                connection.Connecting(s2);
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Lỗi " + ex.Message + " \nBạn có muốn tiếp tục chương trình không ? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
