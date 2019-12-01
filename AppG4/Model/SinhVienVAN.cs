using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Model
{
    class SinhVienVAN : SinhVien
    {
        public float VanHocCD { get; set; }
        public float VanHocHD { get; set; }
     
    public SinhVienVAN(string masv, string hoten, Boolean gioitinh, DateTime ngaysinh, string makhoa, float vanhoccd, float vanhochd) 
            : base(masv,hoten,gioitinh,ngaysinh,makhoa)
    {
       
        this.VanHocCD = vanhoccd;
        this.VanHocHD = vanhochd;
    }

    }
}
