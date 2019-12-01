using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Model
{
    class SinhVienCNTT:SinhVien
    {
        public float Pascal;
        public float C;
        public float SQL;
        public SinhVienCNTT(string masv, string hoten, Boolean gioitinh, DateTime ngaysinh, string makhoa, float pascal, float c, float sql)
               : base(masv, hoten, gioitinh, ngaysinh, makhoa)
        {
            this.Pascal  = pascal;
            this.C = c;
            this.SQL = sql;
            
        }
    }
}
