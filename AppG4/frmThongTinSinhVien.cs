using AppG4.Model;
using AppG4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG4
{
    public partial class frmThongTinSinhVien : Form
    {
        string anhDaiDienPathDirectory;
        string anhDaiDienPathFile;
        string studentPathFile;
        string qthtPathFile;
        public frmThongTinSinhVien(string idStudent)
        {
            InitializeComponent();
            picAnhDaiDien.AllowDrop = true;
            anhDaiDienPathDirectory = Application.StartupPath + @"\AnhDaiDien";
            anhDaiDienPathFile = anhDaiDienPathDirectory + @"\avatar.png";
         /*   studentPathFile = Application.StartupPath + @"\Data\studen_data1.info";
            qthtPathFile = Application.StartupPath + @"\Data\historylearning_data.info";*/
            if (File.Exists(anhDaiDienPathFile))
            {
                FileStream fileStream = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
            //var student = StudenService.GetStudent(idStudent);
            var student = StudenService.GetStudent(Utils.StudentPathFile,idStudent);
            if (student == null)
            {
                throw new Exception("Lỗi rồi. Sinh viên này không tồn tại");

            }

            else
            {
               // student.ListHistoryLearning = QTHTService.GetListHistoryLearning(idStudent);
                student.ListHistoryLearning = QTHTService.GetHistoryLearning(Utils.QthtPathFile, idStudent);
                txtMaSinhVien.Text = student.ID;
                txtHoTen.Text = student.FullName;
                dtpNgaySinh.Value = student.DateOfBirth;
                txtNoiSinh.Text = student.PlaceOfBirth;
                chkGioiTinh.Checked = student.Gender == Model.GENDER.Male;

                dtgQuaTrinhHocTap.AutoGenerateColumns = false;
                bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
                dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;

                lblTongSoMuc.Text = string.Format("{0} ", student.ListHistoryLearning.Count());
            }

        }

        private void LinkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "File ảnh(*.jpg, *.png)|*.png;*.jpg";
            fileDialog.Title = "Chọn ảnh đại diện";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                #region Hiển thị ảnh được chọn lên pictureBox

                var fileName = fileDialog.FileName;
                FileStream fileStream = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);

                var anhDaiDien = Image.FromStream(fileStream);
                picAnhDaiDien.Image = anhDaiDien;
                fileStream.Close();
                #endregion
                #region Lưu ảnh đại diện vào thư mục của chương trình
                //Lưu ảnh đại diện vào thư mục của chương trình
                // @.......... trong đó là hoàn toàn là kí tự bình thường
                //nếu k có thì gõ 2 //

                if (!Directory.Exists(anhDaiDienPathDirectory))
                {
                    Directory.CreateDirectory(anhDaiDienPathDirectory);
                }
                anhDaiDien.Save(anhDaiDienPathFile);
                #endregion
            }
        }

        private void PicAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PicAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var fileNameList = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileStream fileStream = new FileStream(fileNameList.FirstOrDefault(), FileMode.Open, FileAccess.Read);
            var anhDaiDien = Image.FromStream(fileStream);


            #region Lưu ảnh đại diện vào thư mục của chương trình
            if (!Directory.Exists(anhDaiDienPathDirectory))
            {
                Directory.CreateDirectory(anhDaiDienPathDirectory);
            }
            anhDaiDien.Save(anhDaiDienPathFile);


            #endregion
            picAnhDaiDien.Image = anhDaiDien;
            fileStream.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var qtht = bdsQuaTrinhHocTap.Current as QTHT;
            if (qtht != null)
            {
                var resultDialog = MessageBox.Show("Bạn có muốn xóa không",
                    "Thong bao",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                   QTHTService.Remove(Utils.QthtPathFile,qtht);
                    bdsQuaTrinhHocTap.RemoveCurrent();
                    
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            //   Form form = new addForm(txtMaSinhVien.Text);
            //  form.Show();
            var f = new frmQuaTrinhHocTap_chiTiet();
            f.ShowDialog();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var qtht = bdsQuaTrinhHocTap.Current as QTHT;
            if (qtht != null)
            {
                var f = new frmQuaTrinhHocTap_chiTiet(qtht);
                f.ShowDialog();
            }
           /* Form form = new addForm(txtMaSinhVien.Text);
            form.Show();*/
           
        }
    } 
}
