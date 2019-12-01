using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG4.Model;
using AppG4.Service;
using AppG4.DAO;
using System.Data.SqlClient;


namespace AppG4
{
   
    public partial class FormQLSV : Form
    {
        string sinhVienPathFile = Application.StartupPath + @"\Data\sinhvien.info";
       int ma = getMaxMaSV();
    
        public FormQLSV()
        {   
            InitializeComponent();
            //var  listSinhVien = SinhVienService.GetListSinhVien(sinhVienPathFile);
            /*foreach(var sinhvien in listSinhVien)
            {
                checkboxListSinhVien.Items.Add(sinhvien);
              
            }*/
            
            string sql = "select * from SinhVien";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<SinhVien>();
            foreach( DataRow r in data.Rows)
            {
                var sinhvien = new SinhVien(r);
                list.Add(sinhvien);
            }
            dataGridViewSinhVien.AutoGenerateColumns = true;
            bdsSinhVien.DataSource = list ;
            dataGridViewSinhVien.DataSource = bdsSinhVien;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var diem = new Diem("102", "CNTT", 10, 9, 8, 0);
            UpdateDiem(diem);
         

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var sinhvien = bdsSinhVien.Current as SinhVien;
            textBoxHoTen.Text = sinhvien.HoTen;
            if (sinhvien.GioiTinh == true)
            {
                checkBoxGioiTinh.Checked = true;
            }
            txtMSV.Text = sinhvien.MaSV;
            var list = new List<Diem>();
            list = Diem.getListDiem();
            var diemsv = new Diem();
            foreach (var diem in list)
            {
                if (diem.MaSv.Trim().Equals(sinhvien.MaSV.Trim()))
                {
                    diemsv = new Diem(diem.MaSv, diem.MaKhoa, diem.DiemMon1, diem.DiemMon2, diem.DiemMon3, diem.DiemMon4);

                }
            }
            if (diemsv.MaSv != null) { 
            if (diemsv.MaKhoa.Trim().Equals("CNTT"))
            {
                tabPage.SelectedTab = tabCNTT;
                if (diemsv.DiemMon1 != null)
                {
                    txtPascal.Text = diemsv.DiemMon1.ToString();
                }
                if (diemsv.DiemMon2 != null)
                {
                    txtC.Text = diemsv.DiemMon2.ToString();
                }
                if (diemsv.DiemMon3 != null)
                {
                    txtSQL.Text = diemsv.DiemMon3.ToString();
                }
            }
            if (diemsv.MaKhoa.Trim().Equals("VAN"))
            {
                tabPage.SelectedTab = tabVan;
                if (diemsv.DiemMon1 != null)
                {
                    txtVanhocCD.Text = diemsv.DiemMon1.ToString();
                }
                if (diemsv.DiemMon2 != null)
                {
                    txtVanHocHD.Text = diemsv.DiemMon2.ToString();
                }

            }
            if (diemsv.MaKhoa.Trim().Equals("VL"))
            {
                tabPage.SelectedTab = tabVatLi;
                if (diemsv.DiemMon1 != null)
                {
                    txtCoHoc.Text = diemsv.DiemMon1.ToString();
                }
                if (diemsv.DiemMon2 != null)
                {
                    txtQuangHoc.Text = diemsv.DiemMon2.ToString();
                }
                txtDien.Text = diemsv.DiemMon3.ToString();
                if (diemsv.DiemMon3 != null)
                {

                    if (diemsv.DiemMon4 != null)
                    {
                        txtVLHatNhan.Text = diemsv.DiemMon4.ToString();
                    }
                }
            }
            }

            // listBox1.Items.Add(sinhvien);
            //checkedListBoxSinhVien.Items.Add(sinhvien);
            //EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 0], false);*/
            //DateTime ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Value.ToString()); 
            //SinhVien svien = new SinhVien("102", "DatDat", true, ngaysinh, "CNTT");
            //AddSinhVien(svien);
            //UpdateSinhVien(svien);

            //MessageBox.Show(index.ToString());

        }
        ///Code Func Disbale TabPage
        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }
        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        private void sVVănToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            //textBoxHoTen.Text = Index.ToString();
            tabPage.SelectTab(tabVan);
            /*EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 0], true);
            EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 1], false);
            EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 2], false);*/
           
        }

        private void sVVậtLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
           // textBoxHoTen.Text = Index.ToString();
            tabPage.SelectedTab = tabVatLi;
           /* EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 0], false);
            EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 1], true);
            EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 2], false);*/
        }

        private void sVCNTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            //textBoxHoTen.Text = Index.ToString();
            tabPage.SelectedTab = tabCNTT;
            /*  EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 0], false);
              EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 1], false);
              EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 2], true);*/
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            textBoxHoTen.Text = Index.ToString();
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            textBoxHoTen.Text = Index.ToString();
        }

        private void lưuNhữngNgườiĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            textBoxHoTen.Text = Index.ToString();*/
            var listChecked = new List<SinhVien>();

            foreach (SinhVien sinhVien in checkedListBoxSinhVien.CheckedItems)
            {
                // listBox1.Items.Add(sinhVien.HoTen);
                //listChecked.Add(sinhVien);
                AddSinhVien(sinhVien);
            }
           

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Index = ((ToolStripItem)sender).Owner.Items.IndexOf((ToolStripItem)sender);
            //textBoxHoTen.Text = Index.ToString();
            String masv = txtMSV.Text.ToString();
            if (masv != null)
            {
                DeleteSinhVien(masv);
                bdsSinhVien.RemoveCurrent();
            }
        }
        
      
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            String hoten = textBoxHoTen.Text.ToString();
            Boolean gioitinh = Boolean.Parse(checkBoxGioiTinh.Checked.ToString());
            DateTime ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Value.ToString());
            ma = ma + 1;
         
            
            String masv = ma.ToString();
            int tab = tabPage.SelectedIndex;
            String makhoa=null;
            var diem = new Diem();
            diem.MaSv = masv;
            var sv= new SinhVien(masv,hoten,gioitinh,ngaysinh,makhoa);
            if (tab == 0)
            {
                makhoa = "VAN";
               /* diem.MaKhoa = makhoa;
                diem.DiemMon1 = float.Parse(txtVanhocCD.Text.ToString());
                diem.DiemMon2 = float.Parse(txtVanHocHD.Text.ToString());
                diem.DiemMon3 = -1;
                diem.DiemMon4 = -1;
                 sv = new SinhVienVAN(masv, hoten, gioitinh, ngaysinh,makhoa, diem.DiemMon1, diem.DiemMon2);*/

            }
            if (tab == 1)
            {
                makhoa = "VL";
               
            }
            if (tab == 2)
            {
                makhoa = "CNTT";
              
            }
            
            //checkedListBoxSinhVien.Items.Clear();
            checkedListBoxSinhVien.Items.Add(sv);
          
            //AddSinhVien(sv);
            //MessageBox.Show(ma.ToString());
           
        }

        public static int getMaSV()
        {
            var index = 0;
            string sql = "select * from SinhVien";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<SinhVien>();
            foreach (DataRow r in data.Rows)
            {
                var sinhvien = new SinhVien(r);
                list.Add(sinhvien);
            }
            index = list.Count();
            int ma = int.Parse(list[index - 1].MaSV.ToString());
            return ma;
        }
        public static int getMaxMaSV()
        {
          
            string sql = "SELECT MAX(masv) as Ma FROM SinhVien";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<String>();
            foreach (DataRow r in data.Rows)
            {
                String a = r["Ma"].ToString();
                list.Add(a);
            }
            int b = int.Parse(list[0].ToString());
            return b;
        }
        public static String getMaKhoa()
        {
            string sql = "SELECT MAX(masv) as Ma FROM SinhVien";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<String>();
            foreach (DataRow r in data.Rows)
            {
                String a = r["makhoa"].ToString();
                list.Add(a);
            }
            String b = list[0];
            return b;
        }
        private void AddSinhVien(SinhVien sinhvien)
        {
            string sql = "INSERT INTO SinhVien (masv, hoten, gioitinh, ngaysinh,makhoa) VALUES ( @masv , @hoten , @gt , @ns , @mk )";
            object[] a = { "105", "hoanghoang", 0, "2000-12-12", "CNTT" };
            //DataProvider.Instance.ExecuteNonQuery(sql, a);
            var gioitinh = 0;
            if (sinhvien.GioiTinh == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { sinhvien.MaSV, sinhvien.HoTen, gioitinh, sinhvien.NgaySinh.ToString(), sinhvien.MaKhoa });
            MessageBox.Show("Add thanh cong");
            // DataProvider.Instance.ExecuteNonQuery(sql,a);           
        }
        private void UpdateSinhVien(SinhVien sinhvien)
        {
            string sql = "UPDATE SinhVien SET hoten = @hoten ,gioitinh= @gioitinh ,ngaysinh= @ngaysinh ,makhoa= @makhoa WHERE masv = @masv ";
            object[] a = { "105", "hoanghoang", 0, "2000-12-12", "CNTT" };
            //DataProvider.Instance.ExecuteNonQuery(sql, a);
            var gioitinh = 0;
            if (sinhvien.GioiTinh == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            //gioitinh k loi, Insert dc ma, chỉ có update lỗi thôi


            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { sinhvien.HoTen, gioitinh, sinhvien.NgaySinh, sinhvien.MaKhoa, sinhvien.MaSV });
            MessageBox.Show("Update thanh cong");
            // DataProvider.Instance.ExecuteNonQuery(sql,a);   bit ( 0 vs 1) cai ni k loi mo, dong Addsv tren chay ngon lanh r, xuong update loi
            //string sql = "update SinhVien SET  hoten = @ht , gioitinh = @gt , ngaysinh = @ns where id = @id ";
            //DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht, gt, ns, id }); câu lên đó đó, khác gì nhau mô

        }
        private void DeleteSinhVien(String masv)
        {
            string sql = "DELETE FROM SinhVien WHERE masv = @masv ";
          

            DataProvider.Instance.ExecuteNonQuery(sql, new object[] {masv});
            MessageBox.Show("Delete thanh cong");
        

        }
        private void AddDiem(Diem diem)
        {
            string sql = "INSERT INTO DIEM (masv, makhoa, diem1, diem2, diem3, diem4) VALUES ( @masv , @makhoa , @diem1 , @diem2 , @diem3 , @diem4 )";
         
         
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diem.MaSv, diem.MaKhoa, diem.DiemMon1, diem.DiemMon2, diem.DiemMon3,diem.DiemMon4 });
            MessageBox.Show("Add DIEM thanh cong");
            // DataProvider.Instance.ExecuteNonQuery(sql,a);           
        }
        private void UpdateDiem(Diem diem)
        {
            string sql = "UPDATE DIEM SET diem1 = @diem1 ,diem2= @diem2 ,diem3= @diem3 ,diem4= @diem4 WHERE masv = @masv ";
          


            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { diem.DiemMon1, diem.DiemMon2, diem.DiemMon3, diem.DiemMon4, diem.MaSv });
            MessageBox.Show("Update thanh cong");
            // DataProvider.Instance.ExecuteNonQuery(sql,a);   bit ( 0 vs 1) cai ni k loi mo, dong Addsv tren chay ngon lanh r, xuong update loi
            //string sql = "update SinhVien SET  hoten = @ht , gioitinh = @gt , ngaysinh = @ns where id = @id ";
            //DataProvider.Instance.ExecuteNonQuery(sql, new object[] { ht, gt, ns, id }); câu lên đó đó, khác gì nhau mô

        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listDiem = new List<Diem>();
            listDiem = Diem.getListDiem();
            var listInsert = new List<Diem>();
            var listUpdate = new List<Diem>();
            foreach (Diem check in listDiem)
            {

                foreach (Diem items in checkedListBoxCapNhatDiem.CheckedItems)
                     {
                // listBox1.Items.Add(sinhVien.HoTen);
                
                    if (check.MaSv.Trim().Equals(items.MaSv.Trim()))
                    {
                        listUpdate.Add(items);

                    }
                   
                    
                }

               
                
            }
            foreach(Diem diem in listUpdate)
            {
                UpdateDiem(diem);
            } 
          

        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {



            String masv = txtMSV.Text.ToString();
            int tab = tabPage.SelectedIndex;
            String makhoa = null;
            var diem = new Diem();
            diem.MaSv = masv;
         
            if (tab == 0)
            {
                makhoa = "VAN";
                 diem.MaKhoa = makhoa;
                if (txtVanhocCD.Text == null || txtVanHocHD.Text == null)
                {
                    MessageBox.Show("Vui long nhap diem");
                }
                else
                {
                    if (txtVanhocCD.Text != null) { 
                    diem.DiemMon1 = float.Parse(txtVanhocCD.Text.ToString());
                    }
                    if (txtVanHocHD.Text != null)
                    {
                        diem.DiemMon2 = float.Parse(txtVanHocHD.Text.ToString());
                    }
                    diem.DiemMon3 = -1;
                    diem.DiemMon4 = -1;
                }

            }
            if (tab == 1)
            {
                makhoa = "VL";
                diem.MaKhoa = makhoa;
                if (txtCoHoc.Text.ToString() == null || txtQuangHoc.Text.ToString() == null
                    || txtDien.Text.ToString()==null || txtVLHatNhan.Text.ToString()==null)
                {
                    MessageBox.Show("Vui long nhap diem");
                }
                else
                {
                    
                    diem.DiemMon1 = float.Parse(txtCoHoc.Text.ToString());
                    diem.DiemMon2 = float.Parse(txtQuangHoc.Text.ToString());
                    diem.DiemMon3 = float.Parse(txtDien.Text.ToString());
                    diem.DiemMon4 = float.Parse(txtVLHatNhan.Text.ToString());
                }

            }
            if (tab == 2)
            {
                makhoa = "CNTT";
                diem.MaKhoa = makhoa;
                if (txtPascal.Text.ToString() == null || txtC.Text.ToString() == null || txtSQL.Text.ToString() == null)
                {
                    MessageBox.Show("Vui long nhap diem");
                }
                else
                {
                    diem.DiemMon1 = float.Parse(txtPascal.Text.ToString());
                    diem.DiemMon2 = float.Parse(txtC.Text.ToString());
                    diem.DiemMon3 = float.Parse(txtSQL.Text.ToString());
                    diem.DiemMon4 = -1;
                }

            }

            //checkedListBoxSinhVien.Items.Clear();
            checkedListBoxCapNhatDiem.Items.Add(diem);

            //AddSinhVien(sv);
            //MessageBox.Show(ma.ToString());
        }

       








        ////////////
    }
    
}

