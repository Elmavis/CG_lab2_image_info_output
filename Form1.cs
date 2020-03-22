using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using ImageMagick;

namespace Lab2_Fileinfo_output_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //при нажатии на кнопку из указанной папки выбираются все файлы и выводится в таблицу информация о них
        private void Bt_click_Click(object sender, EventArgs e)
        {
            String path = tbAddress.Text;
            path.Replace(@"\", @"\\");
            String[] extensions = { ".jpg", ".gif", ".tif", ".bmp", ".png" };
            String[] filenames = Directory.GetFiles(path);

            for (int i = 0; i < filenames.Length - 1; i++)
            {
                String filename = filenames[i];
                string extension = Path.GetExtension(filename);
                if (extensions.Contains(extension))
                {
                    dgv1.Rows.Add();
                    Image image = Image.FromFile(filename);
                    String[] substrs = filename.Split(new char[] { '\\' });
                    filename = substrs[substrs.Length - 1];
                    dgv1[0, i].Value = filename;
                    dgv1[1, i].Value = image.Width + "x" + image.Height;
                    dgv1[2, i].Value = image.HorizontalResolution;
                    PixelFormat pixForm = image.PixelFormat;
                    dgv1[3, i].Value = Image.GetPixelFormatSize(pixForm);
                    if (extension == ".png")
                        dgv1[4, i].Value = "Deflate";
                    if (extension == ".gif")
                        dgv1[4, i].Value = "LZW";

                }
                else if (extension == ".pcx")
                {
                    dgv1.Rows.Add();
                    MagickImage mi_image = new MagickImage(filename);
                    String[] substrs = filename.Split(new char[] { '\\' });
                    filename = substrs[substrs.Length - 1];
                    dgv1[0, i].Value = filename;
                    dgv1[1, i].Value = mi_image.Width + "x" + mi_image.Height;

                    dgv1[2, i].Value = (int)(mi_image.Width / 25.4); //спросить

                    dgv1[3, i].Value = mi_image.Depth;
                    dgv1[4, i].Value = "RLE";
                }
            }

            //Что касается сжатия, чёрт его знает, потом разберёмся:
            //Guid g = Guid.NewGuid();
            //EncoderParameters x = image.GetEncoderParameterList(g);

            //EncoderParameter ep1 = x.Param[0];
            //EncoderParameter ep2 = x.Param[1];
            //EncoderParameter ep3 = x.Param[2];
        }
    }
}
