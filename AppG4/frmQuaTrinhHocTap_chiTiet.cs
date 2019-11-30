using AppG4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG4
{
    public partial class frmQuaTrinhHocTap_chiTiet : Form
    {
        QTHT qtht;
        public frmQuaTrinhHocTap_chiTiet(QTHT qtht=null)
        {
            InitializeComponent();
            this.qtht = qtht;
            if(qtht != null)
            {
                //Chỉnh sửa
                this.Text = "Chỉnh sửa qá trình học tập";
                numTuNam.Value = qtht.YearFrom;
                numToiNam.Value = qtht.YearEnd;
                txtHocO.Text = qtht.SchoolName;
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới qá trình học tập";
            }
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if (qtht != null)
            {
                //Chỉnh sửa
                qtht.YearFrom = (int)numTuNam.Value;
                qtht.YearEnd = (int)numToiNam.Value;
                qtht.SchoolName = txtHocO.Text;
               // QTHTService.Update("",qtht);
            }
            else
            {
                //THêm mới
                qtht = new QTHT();
                qtht.ID = Guid.NewGuid().ToString();
                qtht.YearFrom = (int)numTuNam.Value;
                qtht.YearEnd = (int)numToiNam.Value;
                qtht.SchoolName = txtHocO.Text;
                //QTHTService.Add("",qtht);
            }
        }
    }
}
