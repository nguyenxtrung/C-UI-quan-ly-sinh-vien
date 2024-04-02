using _20t1020610.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20t1020610
{
    public partial class FormClothes : Form
    {
        Clothes clothes;
        string fileName = "20t1020610.json";
        public FormClothes()
        {
            InitializeComponent();
        }
        // Load data
        void LoadData()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                clothes = Clothes.FromJson(json);
                //ShowData();
                //Hiển thị dữ liệu ra grid
                gridclothes.DataSource = clothes.ListClothes;
            }
        }
        // hien thi du lieu
        void ShowData() 
        {
            if (clothes != null)
            {
                txtMSP.Text = clothes.MSP;
                txtTSP.Text = clothes.TSP;
                dtpNSX.Value = clothes.NSX;
                dtpNHH.Value = clothes.NHH;
                txtGB.Text = clothes.GB.ToString();
                txtGN.Text = clothes.GN.ToString();
                txtSLN.Text = clothes.SLN.ToString();
                pichinhDaidien.ImageLocation = clothes.hinhDaidien;
            }
        }
        // Show data in form
        private void FormClothes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Choose avatar
        private void pichinhDaidien_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pichinhDaidien.ImageLocation = fileName;
            }
        
        }
        // Add data
        private void btnLoad_Click(object sender, EventArgs e)
        {
            clothes = new Clothes
            {
                MSP = "",
                TSP = "",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 0,
                GN = 0,
                SLN = 0,
                ListClothes = new List<Clothes>()
            };
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "1",
                TSP = "T-Shirt",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 150000,
                GN = 50000,
                SLN = 10,
                ListClothes = new List<Clothes>()
            });
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "2",
                TSP = "Shirt",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 250000,
                GN = 100000,
                SLN = 10,
            });
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "3",
                TSP = "Trouser",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 350000,
                GN = 150000,
                SLN = 10,
            });
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "4",
                TSP = "Flare Pants",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 400000,
                GN = 200000,
                SLN = 10,
            });
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "5",
                TSP = "Baggy Jeans",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 500000,
                GN = 300000,
                SLN = 10,
            });
            clothes.ListClothes.Add(new Clothes
            {
                MSP = "6",
                TSP = "Suit",
                NSX = new DateTime(2004, 2, 4),
                NHH = new DateTime(2004, 2, 4),
                GB = 2000000,
                GN = 4000000,
                SLN = 10,
            });
            MessageBox.Show(
                "Load dữ liệu xong", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            File.WriteAllText(fileName, clothes.ToString());
            gridclothes.DataSource = clothes.ListClothes;
            MessageBox.Show(
                    "Load dữ liệu xong", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        // Take data from an object and replace values on txt and datetime

        private void gridclothes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Clothes selectedClothes = clothes.ListClothes[e.RowIndex];

                // Lấy giá trị từ đối tượng Sach và gán vào các TextBox và DateTimePicker
                txtMSP.Text = selectedClothes.MSP;
                txtTSP.Text = selectedClothes.TSP;
                dtpNSX.Value = selectedClothes.NSX;
                dtpNHH.Value = selectedClothes.NHH;
                txtGB.Text = selectedClothes.GB.ToString();
                txtGN.Text = selectedClothes.GN.ToString();
                txtSLN.Text = selectedClothes.SLN.ToString();
                pichinhDaidien.ImageLocation = selectedClothes.hinhDaidien;
            }
        }

        /*Add, Delete, Update, Load*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ràng buộc dữ liệu trước khi thêm
            if (string.IsNullOrWhiteSpace(txtMSP.Text) ||
                string.IsNullOrWhiteSpace(txtTSP.Text) ||
                string.IsNullOrWhiteSpace(txtGN.Text) ||
                string.IsNullOrWhiteSpace(txtGB.Text) ||
                string.IsNullOrWhiteSpace(txtSLN.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin của sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng quá trình thêm nếu có thông tin thiếu
            }

            if (!decimal.TryParse(txtGN.Text, out decimal GN) ||
                !decimal.TryParse(txtGB.Text, out decimal GB) ||
                !int.TryParse(txtSLN.Text, out int SLN))
            {
                MessageBox.Show("Giá nhập, giá bán và số lượng nhập phải là số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng quá trình thêm nếu thông tin không hợp lệ
            }

            // Tạo một đối tượng sách mới
            Clothes newSach = new Clothes
            {
                MSP = txtMSP.Text,
                TSP = txtTSP.Text,
                NSX = dtpNSX.Value,
                NHH = dtpNHH.Value,
                GN = (int)decimal.Parse(txtGN.Text),
                GB = (int)decimal.Parse(txtGB.Text),
                SLN = (int)decimal.Parse(txtSLN.Text),
                hinhDaidien = pichinhDaidien.ImageLocation
            };

            // Thêm quyển sách mới vào danh sách
            clothes.ListClothes.Add(newSach);

            // Cập nhật DataGridView để hiển thị quyển sách mới
            gridclothes.DataSource = null;
            gridclothes.DataSource = clothes.ListClothes;

            // Xóa dữ liệu trên TextBox và DateTimePicker
            txtMSP.Text = string.Empty;
            txtTSP.Text = string.Empty;
            dtpNSX.Value = DateTime.Now;
            txtGN.Text = string.Empty;
            txtGB.Text = string.Empty;
            txtSLN.Text = string.Empty;
            pichinhDaidien.ImageLocation = string.Empty;

            // Lưu danh sách sách vào tệp JSON
            //File.WriteAllText(fileName, sach.ToString());
            string json = JsonConvert.SerializeObject(clothes);
            File.WriteAllText(fileName, json);
            MessageBox.Show(
                "Thêm thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã sách cần cập nhật
            string MSPCanCapNhat = txtMSP.Text;

            // Tìm quyển sách trong danh sách dựa trên mã sách
            Clothes clothesCanCapNhat = clothes.ListClothes.FirstOrDefault(s => s.MSP == MSPCanCapNhat);

            if (clothesCanCapNhat != null)
            {
                // Cập nhật thông tin sách từ TextBox và DateTimePicker
                clothesCanCapNhat.TSP = txtTSP.Text;
                clothesCanCapNhat.NSX = dtpNSX.Value;
                clothesCanCapNhat.GN = (int)decimal.Parse(txtGN.Text);
                clothesCanCapNhat.GB = (int)decimal.Parse(txtGB.Text);
                clothesCanCapNhat.SLN = (int)decimal.Parse(txtSLN.Text);
                clothesCanCapNhat.hinhDaidien = pichinhDaidien.ImageLocation;

                // Cập nhật DataGridView để hiển thị thông tin cập nhật
                gridclothes.DataSource = null;
                gridclothes.DataSource = clothes.ListClothes;

                // Lưu lại danh sách sách sau khi cập nhật
                string json = JsonConvert.SerializeObject(clothes);
                File.WriteAllText(fileName, json);

                MessageBox.Show(
                    "Cập nhật thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm và mã sản phẩm cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập mã sách cần xóa
            string MSPCanXoa = txtMSP.Text;

            // Tìm quyển sách trong danh sách dựa trên mã sách
            Clothes clothesCanXoa = clothes.ListClothes.FirstOrDefault(s => s.MSP == MSPCanXoa);

            if (clothesCanXoa != null)
            {
                // Xóa quyển sách khỏi danh sách
                clothes.ListClothes.Remove(clothesCanXoa);

                // Cập nhật DataGridView để hiển thị danh sách mới sau khi xóa
                gridclothes.DataSource = null;
                gridclothes.DataSource = clothes.ListClothes;

                // Lưu lại danh sách sách sau khi xóa
                string json = JsonConvert.SerializeObject(clothes);
                File.WriteAllText(fileName, json);

                MessageBox.Show(
                    "Xóa thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm và mã sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
