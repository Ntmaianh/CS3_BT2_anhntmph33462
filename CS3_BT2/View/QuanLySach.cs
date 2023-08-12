using CS3_BT2.Controller;
using CS3_BT2.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3_BT2.View
{
    public partial class QuanLySach : Form
    {
        Services _services = new Services();
        Guid? _idWhenClick;
        List<Guid> lstIdNXB = new List<Guid>();
        public QuanLySach()
        {
            InitializeComponent();
        }
        private void LoadDaTa(string find)
        {
            dgvSach.ColumnCount = 6;
            int stt = 1;
            dgvSach.Columns[0].Name = "Id";
            dgvSach.Columns[1].Name = "STT";
            dgvSach.Columns[2].Name = "Mã sách";
            dgvSach.Columns[3].Name = "Tên Sách";
            dgvSach.Columns[4].Name = "NXB";
            dgvSach.Columns[5].Name = "Trạng thái";
            dgvSach.Rows.Clear();
            dgvSach.Columns[0].Visible = false;
            dgvSach.Columns[5].Visible = false;

            foreach (var item in _services.getSach(find))
            {
                var Nsb = _services.getNhaXuatBan().FirstOrDefault(x => x.Id == item.IdNxb);
                dgvSach.Rows.Add(item.Id, stt++, item.Ma, item.Ten, Nsb == null ? "Sách lậu" : Nsb.Ten, item.TrangThai);
            }

        }
        private void LoadNXB()
        {

            foreach (var item in _services.getNhaXuatBan())
            {
                lstIdNXB.Add(item.Id);
                cbNXB.Items.Add(item.Ten);
            }
            cbNXB.SelectedIndex = 0;
        }
        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idWhenClick = Guid.Parse(dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString());
            var resurt = _services.getSach(null).First(x => x.Id == _idWhenClick);
            txtMa.Text = resurt.Ma;
            txtTen.Text = resurt.Ten;

            if (resurt.TrangThai == 1)
            {
                radbtnConHang.Checked = true;
                radbtnHetHang.Checked = false;
            }
            else if (resurt.TrangThai == 0)
            {
                radbtnConHang.Checked = false;
                radbtnHetHang.Checked = true;
            }
            int index = lstIdNXB.FindIndex(x => x == resurt.IdNxb);
            cbNXB.SelectedIndex = index;

        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            LoadNXB();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDaTa(null);
        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Sach sach = new Sach();
                if (checkTrungMa() == false)
                {
                    MessageBox.Show("Mã sách trùng !!");
                    return;
                }
                else
                {
                    sach.Ma = txtMa.Text;
                }
                sach.Ten = txtTen.Text;
                if (radbtnConHang.Checked)
                {
                    sach.TrangThai = 1;
                }
                else
                {
                    sach.TrangThai = 0;
                }
                sach.IdNxb = lstIdNXB[cbNXB.SelectedIndex];
                _services.AddSach(sach);
                LoadDaTa(null);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi rồi !");
            }
        }
        private bool checkTrungMa()
        {
            if (_services.getSach(null).Any(x => x.Ma == txtMa.Text))
            {
                return false;
            }
            return true;
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            lable.Text = "";
            txtTen.Text = "";
            cbNXB.SelectedIndex = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Sach sach = new Sach();
                if (checkTrungMa() == false)
                {
                    MessageBox.Show("Mã sách trùng !!");
                    return;
                }
                else
                {
                    sach.Ma = txtMa.Text;
                }
                sach.Ten = txtTen.Text;
                if (radbtnConHang.Checked)
                {
                    sach.TrangThai = 1;
                }
                else
                {
                    sach.TrangThai = 0;
                }
                sach.IdNxb = lstIdNXB[cbNXB.SelectedIndex];

                DialogResult result = MessageBox.Show("Lưu thay đôi ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _services.UpDateSach(_idWhenClick, sach);
                    LoadDaTa(null);
                    _idWhenClick = null;
                }
                else
                {
                    MessageBox.Show("Lưu không thành công!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi rối");
            }

        }
    }
}
