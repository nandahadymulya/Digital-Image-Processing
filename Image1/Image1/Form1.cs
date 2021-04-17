using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; /*Untuk membuat program file gambar 
dari apa yang ada di PictureBox ke dalam file berformat JPG*/

namespace Image1
{
    public partial class Form1 : Form
    {
        Image File;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*untuk membuat program membaca file gambar dan
            menampilkannya di Picturebox*/
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = File;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*untuk menyimpan gambar dalam format yang berbeda
            misal dari PNG ke dalam file berformat JPEG*/
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                File.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
