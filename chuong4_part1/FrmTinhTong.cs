using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_part1
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

       /* private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 0) && (e.KeyChar <= 9)) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8 || (Convert.ToInt32(e.KeyChar) == 13)))
                e.Handled = false;
            else e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 0) && (e.KeyChar <= 9)) || (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8 || (Convert.ToInt32(e.KeyChar) == 13)))
                e.Handled = false;
            else e.Handled = true;
        }
        */
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            double tong;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            tong = a + b;

            MessageBox.Show("Tong A va B la " + tong);
        }
    }
}
