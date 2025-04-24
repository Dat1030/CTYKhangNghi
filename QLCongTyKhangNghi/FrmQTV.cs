using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTyKhangNghi
{
    public partial class FrmQTV : Form
    {
        public FrmQTV()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatLaiMK());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDatLaiMK());
        }
    }
}
