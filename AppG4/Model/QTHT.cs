using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Model
{
    public class QTHT
    {
        public string ID { get; set; }
        public int YearFrom { get; set; }
        public int YearEnd { get; set; }
        public string SchoolName { get; set; }
        public string IDStudent { get; set;}
        public virtual Student Student { get; set; }
        public object Guid { get; internal set; }

        /// <summary>
        /// CHuyển đổi 1 chuỗi dạng ma#tuNam#denNam#noiHoc#Msv thành đối tượng
        /// </summary>
        /// <param name="dataSing">Chuối theo định dạng</param>
        /// <returns>QTHT</returns>
        public static QTHT Parse(string dataString)
        {
            var items = dataString.Split(new char[] { '#' });
            QTHT qtht = new QTHT
            {
                ID = items[0],
                YearFrom = int.Parse(items[1]),
                YearEnd = int.Parse(items[2]),
                SchoolName = items[3],
                IDStudent = items[4]

            };
            return qtht;
        }
        /// <summary>
        /// Chuyển đổi 1 đối tượng thành 1 chuỗi 
        /// </summary>
        /// <param name="qtht"></param>
        /// <returns>S</returns>
        public static String Parse(QTHT qtht)
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}", 
                qtht.ID,
                qtht.YearFrom, 
                qtht.YearEnd, 
                qtht.SchoolName,
                qtht.IDStudent);
        }
        public  String Parse()
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}",
                this.ID,
                this.YearFrom,
                this.YearEnd,
                this.SchoolName,
                this.IDStudent);
        }

    }
}
