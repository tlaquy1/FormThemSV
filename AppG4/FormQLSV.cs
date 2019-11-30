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
           /* var listChecked = new List<SinhVien>();
           
            foreach(SinhVien sinhVien in checkedListBoxSinhVien.CheckedItems)
            {
               // listBox1.Items.Add(sinhVien.HoTen);
                listChecked.Add(sinhVien);
            }
            SinhVien sv = listChecked[0];
            textBoxHoTen.Text = sv.HoTen;
            if (sv.GioiTinh == true)
            {
                checkBoxGioiTinh.Checked = true;

            }
            else
            {
                checkBoxGioiTinh.Checked = false;
            }
            var Date = new DateTime();
            Date = sv.NgaySinh;
            dateTimePickerNgaySinh.Value = Date;
         
            if (sv.MaKhoa.Trim().Equals("CNTT"))
            {
                tabPage.SelectedTab = tabCNTT;
               


            }
          
              else
              {
                  if (sv.MaKhoa == "VAN")
                  {
                      tabPage.SelectedTab = tabVan;
                  }
                  else
                  {
                      if (sv.MaKhoa == "VL")
                      {
                          tabPage.SelectedTab = tabVatLi;
                      }
                  }
              }*/

         

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            /*var sinhvien = bdsSinhVien.Current as SinhVien;
            textBoxHoTen.Text=sinhvien.HoTen;
            if (sinhvien.GioiTinh == true)
            {
                checkBoxGioiTinh.Checked =true;
            }
           // listBox1.Items.Add(sinhvien);
            checkedListBoxSinhVien.Items.Add(sinhvien);
            //EnableTab(tabPage.TabPages[tabPage.SelectedIndex = 0], false);
            DateTime ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Value.ToString()); 
            SinhVien svien = new SinhVien("102", "DatDat", true, ngaysinh, "CNTT");*/
               //AddSinhVien(svien);
           // UpdateSinhVien(svien);
           
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
        }
        private void AddSinhVien(SinhVien sinhvien)
        {
            string sql = "INSERT INTO SinhVien (masv, hoten, gioitinh, ngaysinh,makhoa) VALUES ( @masv , @hoten , @gt , @ns , @mk )";
            object[] a = { "105","hoanghoang",0,"2000-12-12","CNTT"};
            //DataProvider.Instance.ExecuteNonQuery(sql, a);
            var gioitinh=0;
            if (sinhvien.GioiTinh == true)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            DataProvider.Instance.ExecuteNonQuery(sql, new object[]{ sinhvien.MaSV,sinhvien.HoTen,gioitinh, sinhvien.NgaySinh.ToString(), sinhvien.MaKhoa});
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
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { sinhvien.MaSV, sinhvien.HoTen, gioitinh, sinhvien.NgaySinh.ToString(), sinhvien.MaKhoa });
            MessageBox.Show("Update thanh cong");
            // DataProvider.Instance.ExecuteNonQuery(sql,a);           
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
            if (tab == 0)
            {
                makhoa = "VAN";
            }
            if (tab == 1)
            {
                makhoa = "VL";
            }
            if (tab == 2)
            {
                makhoa = "CNTT";
            }
            SinhVien sv = new SinhVien(masv, hoten, gioitinh, ngaysinh, makhoa);
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
            var index = 0;
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


    }
    
}

