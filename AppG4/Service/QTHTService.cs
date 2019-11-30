using AppG4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Service
{
    class QTHTService
    {
        /// <summary>
        /// Lấy danh sách quá trình học tập của một sinh viên dựa vào idStudent
        /// </summary>
        /// <param name="idStudent">Mã sin viên</param>
        /// <returns>Quá trình học tập</returns>
        public static List<QTHT> GetListHistoryLearning(string idStudent)
        {

            List<QTHT> histories = new List<QTHT>();
            for (int i =1; i <= 12; i++)
            {
                QTHT history = new QTHT
                {
                    ID = i.ToString(),
                    YearFrom = 2000 + i,
                    YearEnd = 2000 + i,
                    SchoolName = "Phan Bội Châu",
                    IDStudent = idStudent

                };
                histories.Add(history);
            }
            return histories;
        }
        /// <summary>
        /// Lấy quá trình học tập của sinh viên có MSV là idStudent từ file
        /// </summary>
        /// <param name="path">Đường dẫy tới file</param>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>List quá trình học tập</returns>
        public static List<QTHT> GetListHistoryLearning(string path,string idStudent)
        {
            List<QTHT> histories = new List<QTHT>();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var items = line.Split(new char[] { '#' });
                if (items.Length == 5)
                {
                    var qtht = new QTHT
                    {
                        ID = items[0],
                        YearFrom = int.Parse(items[1]),
                        YearEnd = int.Parse(items[2]),
                        SchoolName = items[3],
                        IDStudent = items[4]
                    };
                    if (qtht.IDStudent == idStudent)
                        histories.Add(qtht);
                }
            }
            return histories;
        }
        /// <summary>
        /// Lấy danh sách quá rình học tập của 1 sv dựa vào file
        /// </summary>
        /// <param name="path">Đường dẫn chứa file dữ liệu</param>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Danh sách quá trình học tập của một sinh viên</returns>
        public static List<QTHT> GetHistoryLearning(string path, string idStudent)
        {
            List<QTHT> histories = new List<QTHT>();
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach(var line in lines)
                {
                    //Line: ma#tuNam#denNam#noiHoc#Msv
                    var qtht = QTHT.Parse(line);
                    if (qtht.IDStudent == idStudent)
                        histories.Add(qtht);
                }
            }else
                return null;
            return histories;
        }
        public static void Remove(string path,QTHT qtht)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach(var line in lines)
                {
                    var data = QTHT.Parse(line);
                    if (data.ID != qtht.ID)
                    {
                        rs.Add(line);
                    }
                }
                File.WriteAllLines(path, rs);
            }
            else
                throw new Exception("File dữ liệu không có tồn tại");
        }
        public static void Add(string path,QTHT qtht)
        {
            
        }
        public static void Update(string path, QTHT qtht)
        {

        }

    }
}
