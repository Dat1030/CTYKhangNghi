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
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            custom();
        }
        public void custom()
        {
            panelSubMenu1.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu1.Visible)
            {
                panelSubMenu1.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!= null)
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

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu1);
        }

        private void btnQLSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLSanPham());
            lblTieuDe.Text = btnQLSanPham.Text;
            hideSubMenu();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLNhanVien());
            lblTieuDe.Text = btnQLNhanVien.Text;
            hideSubMenu();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQLKhachHang());
            lblTieuDe.Text = btnQLKhachHang_Click.Text;
            hideSubMenu();
        }
    }
}   
