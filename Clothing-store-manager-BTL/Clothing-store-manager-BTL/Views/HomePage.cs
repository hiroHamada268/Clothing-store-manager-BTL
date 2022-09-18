using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_store_manager_BTL.Views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            Ttime.Start();
        }

        private void Ttime_Tick(object sender, EventArgs e)
        {
            LBtime.Text = DateTime.Now.ToString();
        }
    }
}
