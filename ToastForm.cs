using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peringatan_notif
{
    public partial class Toast : Form
    {
        int toastX, toasY;
        public Toast()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            toastX = ScreenWidth - this.Width;
            toasY = ScreenHeight - this.Height;
            this.Location = new Point(toastX, toasY);

        }
    }
}
