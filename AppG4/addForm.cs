using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG4.Service;
using AppG4.Model;

namespace AppG4
{
  
    public partial class addForm : Form
    {
       
        string qthtPathFile;
        public addForm(string idStudent)
        {
            InitializeComponent();
            
           
            List<QTHT> qtht = new List<QTHT>();
            qthtPathFile = Application.StartupPath + @"\Data\QTHT_data.info";
           
          /*  numericTuNam.Maximum = DateTime.Now.Year;
            numericToiNam.Maximum = DateTime.Now.Year;*/
            qtht = QTHTService.GetListHistoryLearning(qthtPathFile, idStudent);
            int itemNumber = qtht.Count;
            numericTuNam.Value = qtht[itemNumber-1].YearFrom;
            numericToiNam.Value = qtht[itemNumber-1].YearEnd;
            

        }

     

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chưa thêm được đâu anh eii");
        }
    }
}
