using Hoangpdph31561_CSharp_3_BaiTap_2.Controller.Respository;
using Hoangpdph31561_CSharp_3_BaiTap_2.Controller.Service;
using Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.View
{
    public partial class QuanLySach : Form
    {
        SachRespository _res = new SachRespository();
        SachService _sachService = new SachService();
        Guid idNhaXuatBanWhenClick;
        string idSachWhenClick;
        public QuanLySach()
        {
            InitializeComponent();
            radConHang.Checked = true;
            radHetHang.Checked = false;
            LoadComboBox();
            LoadData(null);
        }
        public void LoadComboBox()
        {
            foreach (var item in _res.GetNhaXuatBans())
            {
                cmbNhaXuatBan.Items.Add(item.TenNhaXuatBan);
            }
            cmbNhaXuatBan.SelectedIndex = 1;
        }
        public void LoadData(string? input)
        {
            int soThuTu = 1;
            Type type = typeof(Sach);
            dgvSach.ColumnCount = type.GetProperties().Length + 1;
            dgvSach.Columns[0].Name = "STT";
            dgvSach.Columns[1].Name = "Mã sách";
            dgvSach.Columns[2].Name = "Tên sách";
            dgvSach.Columns[3].Name = "Trạng thái";
            dgvSach.Columns[4].Name = "Nhà xuất bản";
            dgvSach.Rows.Clear();

            if (input == null)
            {
                var data = _res.GetSachs();
                for (int i = 0; i < data.Count; i++)
                {
                    dgvSach.Rows.Add(soThuTu++, data[i].IdSach, data[i].TenSach, (data[i].TrangThai == true ? "Còn hàng" : "Hết hàng"), _res.GetNhaXuatBans().Where(x => x.IdNhaXuatBan == data[i].IdNhaXuatBan).Select(x => x.TenNhaXuatBan).FirstOrDefault());
                    dgvSach.Rows[i].Tag = data[i].IdNhaXuatBan;
                }
            }
            else
            {
                var data = _res.GetSachs(input);
                for (int i = 0; i < data.Count; i++)
                {
                    dgvSach.Rows.Add(soThuTu++, data[i].IdSach, data[i].TenSach, (data[i].TrangThai == true ? "Còn hàng" : "Hết hàng"), _res.GetNhaXuatBans().Where(x => x.IdNhaXuatBan == data[i].IdNhaXuatBan).Select(x => x.TenNhaXuatBan).FirstOrDefault());
                    dgvSach.Rows[i].Tag = data[i].IdNhaXuatBan;
                }
            }

        }
        public bool CheckText()
        {
            err.SetError(txtMaSach, "");
            err.SetError(txtTenSach, "");
            if (Helper.CheckTextExist(txtMaSach.Text))
            {
                err.SetError(txtMaSach, "Chưa nhập mã sách");
                return false;
            }
            else if (_res.GetSachs(null).Any(x => x.IdSach == txtMaSach.Text))
            {
                err.SetError(txtMaSach, "Mã sách bị trùng");
                return false;
            }
            if (Helper.CheckTextExist(txtTenSach.Text))
            {
                err.SetError(txtTenSach, "Chưa nhập tên sách");
                return false;
            }
            return true;
        }
        public bool CheckTextWithoutIdSach()
        {
            err.SetError(txtMaSach, "");
            err.SetError(txtTenSach, "");
            if (Helper.CheckTextExist(txtMaSach.Text))
            {
                err.SetError(txtMaSach, "Chưa nhập mã sách");
                return false;
            }
            if (Helper.CheckTextExist(txtTenSach.Text))
            {
                err.SetError(txtTenSach, "Chưa nhập tên sách");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckText())
            {
                Sach sach = new Sach();
                sach.IdSach = txtMaSach.Text;
                sach.TenSach = txtTenSach.Text;
                if (radConHang.Checked)
                {
                    sach.TrangThai = true;
                }
                else if (radHetHang.Checked)
                {
                    sach.TrangThai = false;
                }
                string tenNhaXuatBanDuocChon = cmbNhaXuatBan.SelectedItem.ToString();
                var data = _res.GetNhaXuatBans().Where(x => x.TenNhaXuatBan == tenNhaXuatBanDuocChon).FirstOrDefault();
                sach.IdNhaXuatBan = data.IdNhaXuatBan;
                _sachService.AddNewSach(sach);

            }
            LoadData(null);
            ResetTextBox();

        }
        public void ResetTextBox()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cmbNhaXuatBan.SelectedIndex = 1;
            radConHang.Checked = true;
            radHetHang.Checked = false;
            txtMaSach.Enabled = true;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Enabled = false;
            int index = e.RowIndex;
            if (index < 0 || index == _res.GetSachs(null).Count)
            {
                return;
            }
            idSachWhenClick = dgvSach.Rows[index].Cells[1].Value.ToString();
            txtMaSach.Text = dgvSach.Rows[index].Cells[1].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[index].Cells[2].Value.ToString();
            string tinhTrang = dgvSach.Rows[index].Cells[3].Value.ToString();
            if (tinhTrang == "Còn hàng")
            {
                radConHang.Checked = true;
            }
            else
            {
                radHetHang.Checked = true;
            }
            DataGridViewRow row = dgvSach.Rows[index];

            if (row != null)
            {
                idNhaXuatBanWhenClick = (Guid)row.Tag;
            }
            var data = _res.GetNhaXuatBans().FirstOrDefault(x => x.IdNhaXuatBan == idNhaXuatBanWhenClick);
            cmbNhaXuatBan.SelectedItem = data.TenNhaXuatBan;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckTextWithoutIdSach())
            {
                if (idSachWhenClick == null)
                {
                    MessageBox.Show("Không sửa được");
                    LoadData(null);
                    ResetTextBox();
                    return;

                }
                Sach updateSach = new Sach();
                updateSach.IdSach = idSachWhenClick;
                updateSach.TenSach = txtTenSach.Text;
                if (radConHang.Checked)
                {
                    updateSach.TrangThai = true;
                }
                else
                {
                    updateSach.TrangThai = false;
                }
                string tenNhaXuatBanDuocChon = cmbNhaXuatBan.SelectedItem.ToString();
                var data = _res.GetNhaXuatBans().Where(x => x.TenNhaXuatBan == tenNhaXuatBanDuocChon).FirstOrDefault();
                updateSach.IdNhaXuatBan = data.IdNhaXuatBan;
                MessageBox.Show(_res.UpdateSachs(idSachWhenClick, updateSach));
            }
            LoadData(null);
            ResetTextBox();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                LoadData(null);
            }
            else
            {
                LoadData(txtTimKiem.Text);
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_Move(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên để tìm kiếm";
            LoadData(null);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
    }
}
