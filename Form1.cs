using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpquanlynhanvien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Add("Nguyễn Thị Phước\tAn");
            lsbketqua.Items.Add("Trà Hoàng\tAn");
            lsbketqua.Items.Add("Trần Lê Thanh\tBảo");
            lsbketqua.Items.Add("Nguyễn Thị Hồng\tĐào");
            lsbketqua.Items.Add("Nguyễn Văn\tDinh");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.RemoveAt(lsbketqua.SelectedIndex);
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            if (lsbketqua.SelectedIndex < 0) return;
            lsbketqua.Items[lsbketqua.SelectedIndex] = txtso.Text;
        }
    }
}
