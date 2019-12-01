using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppG4.DAO;

namespace AppG4.Model
{
    class Diem
    {
        public String MaSv;
        public String MaKhoa;
        public float DiemMon1;
        public float DiemMon2;

        public float DiemMon3;

        public float DiemMon4;
        public Diem()
        {

        }
        public Diem(String masv, String makhoa,float diemmon1, float diemmon2,float diemmon3, float diemmon4)
        {
            this.MaSv = masv;
            this.MaKhoa = makhoa;
            this.DiemMon1 = diemmon1;
            this.DiemMon2 = diemmon2;
            this.DiemMon3 = diemmon3;
            this.DiemMon4 = diemmon4;
        }
        public Diem(DataRow r)
        {
            this.MaSv = r["masv"].ToString();
            this.MaKhoa = r["makhoa"].ToString();
            this.DiemMon1 = float.Parse(r["diem1"].ToString());
            this.DiemMon2 = float.Parse(r["diem2"].ToString());
            this.DiemMon3 = float.Parse(r["diem3"].ToString());
            this.DiemMon4 = float.Parse(r["diem4"].ToString());


        }
        public static List<Diem> getListDiem()
        {
            string sql = "select * from DIEM";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            var list = new List<Diem>();
            foreach (DataRow r in data.Rows)
            {
                var diem = new Diem(r);
                list.Add(diem);
            }
            return list;
        }
        public override string ToString()
        {
            return this.MaSv;
        }


    }
}
