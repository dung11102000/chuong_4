using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_part1_BT1
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 9)
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 0 && e.KeyChar <= 9)
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("A invalid");
                txta.Focus();
                return;
            }
            if (txtb.Text == "")
            {
                MessageBox.Show("B invalid");
                txtb.Focus();
                return;
            }
                int tong=0;
            int a = Convert.ToInt32(txta.Text);
            int b = Convert.ToInt32(txtb.Text);
            
            if (a <= b)
            {
                for (int i = a; i <= b; i++)
                    tong = tong + i;
            }
            else
            {
                for (int i = b; i <= a; i++)
                    tong = tong + i;
            }
            lbResult.Text = "sum: "+ tong;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            lbResult.Text = "";
            txta.Focus();
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

    }
}
