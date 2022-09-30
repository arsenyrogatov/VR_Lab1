using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VR_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                status_label.Text = "Файл: " + openFileDialog.FileName;
                RgbToYuv(openFileDialog.FileName);
            }
        }

        private void RgbToYuv (string path)
        {
            rgb_pictureBox.Image = Image.FromFile(path);
            Bitmap bitmap = new Bitmap(path);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int y_channel = (int)(pixelColor.R * .299000 + pixelColor.G * .587000 + pixelColor.B * .114000);
                    Color newColor = Color.FromArgb(y_channel, y_channel, y_channel);
                    bitmap.SetPixel(x, y, newColor);
                }
            }

            yuv_pictureBox.Image = bitmap;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                if (System.IO.Path.GetExtension(file).ToUpper()==".BMP")
                {
                    status_label.Text = "Файл: " + file;
                    RgbToYuv(file);
                }
            }
        }
    }
}
