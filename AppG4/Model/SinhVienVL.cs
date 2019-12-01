using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Model
{
    class SinhVienVL:SinhVien
    {

        public float CoHoc { get; set; }
        public float QuangHoc { get; set; }
        public float Dien { get; set; }
        public float VLHatNhat { get; set; }

        public SinhVienVL(string masv, string hoten, Boolean gioitinh, DateTime ngaysinh, string makhoa, float cohoc, float quanghoc, float dien, float vlhatnhan)
                : base(masv, hoten, gioitinh, ngaysinh, makhoa)
        {
            this.CoHoc = cohoc;
            this.QuangHoc = quanghoc;
            this.Dien = dien;
            this.VLHatNhat = vlhatnhan;
        }
    }
}
