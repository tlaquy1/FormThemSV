using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
using AppG4.Model;
using AppG4.DAO;
using System.Data;

namespace AppG4.Service
{
    class SinhVienService
    {
        /*public static SinhVien GetSinhVien(string path, string idStudent)
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var items = line.Split(new char[] { '#' });
                if (items.Length == 6)
                {
                    var sinhvien = new SinhVien
                    {
                        MaSV = items[0],
                        HoTen=items[1],
                        NgaySinh= DateTime.ParseExact(items[2], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        GioiTinh =Boolean.Parse(items[3]),
                        MaKhoa=items[4]
                    };
                    if (sinhvien.MaSV == idStudent)
                        return sinhvien;
                }
            }
            return null;
        }*/
        /*public static List<SinhVien> GetListSinhVien(string path)
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var items = line.Split(new char[] { '#' });
                if (items.Length == 5)
                {
                    var sinhvien = new SinhVien
                    {
                        MaSV = items[0],
                        HoTen = items[1],
                        NgaySinh = DateTime.ParseExact(items[2], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                        GioiTinh = Boolean.Parse(items[3]),
                        MaKhoa = items[4]
                    };
                  
                        listSinhVien.Add(sinhvien);
                }
            }
            return listSinhVien;
        }*/
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
            return index;
        }
    }
}
