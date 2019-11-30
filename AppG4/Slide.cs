using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG4
{
  
    public partial class Slide : Form
    {
        string anhDaiDienPathDirectory;
        string anhDaiDienPathFile;
        public Slide()
        {
           
            InitializeComponent();
            picImage.AllowDrop = true;
            anhDaiDienPathDirectory = Application.StartupPath + @"\AnhSlide";
            anhDaiDienPathFile = anhDaiDienPathDirectory + @"\1.jpg";
            if (File.Exists(anhDaiDienPathFile))
            {
                FileStream fileStream = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);
                picImage.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }
        }

        private void Slide_Load(object sender, EventArgs e)
        {
           
                #region Hiển thị ảnh được chọn lên pictureBox

                
                var anhDaiDien = Image.FromFile(anhDaiDienPathFile);
                picImage.Image = anhDaiDien;
           
                #endregion
            
            
        }
    }
}
