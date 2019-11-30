using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AppG4.DAO;

namespace AppG4.Model
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
       
        public DateTime NgaySinh { get; set; }
        public Boolean GioiTinh { get; set; }
     
        public string MaKhoa { get; set; }
        public SinhVien(string masv, string hoten, Boolean gioitinh, DateTime ngaysinh, string makhoa)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.MaKhoa = makhoa;
        }
        public SinhVien(DataRow r)
        {
            this.MaSV = r["masv"].ToString();
            this.HoTen = r["hoten"].ToString();
            this.GioiTinh = Boolean.Parse(r["gioitinh"].ToString());
            this.NgaySinh = DateTime.Parse(r["ngaysinh"].ToString());
            this.MaKhoa = r["makhoa"].ToString();
        }
        public override string ToString()
        {
            return this.HoTen;
        }
       
    }
    
}
