using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Imageupload
{
    public partial class Form1 : Form
    {
        OpenFileDialog of;
        String ext = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (btnupload.Text == "Image Upload")
            {
                of = new OpenFileDialog();
                of.Filter = "Image Files (*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png ";
                of.ShowDialog();

                if (of.FileName != "") 
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(of.FileName);
                    btnupload.Text = "Save";
                    //MessageBox.Show(of.FileName);
                }
            }
            else 
            {
                Random r = new Random();
                string no = r.Next().ToString();
                FileInfo fio = new FileInfo(of.FileName);
                ext = fio.Extension;
                string newfnm = no + ext;
                String oldnm = Application.StartupPath;
                int len = oldnm.Length - 9;
                string newpath = Application.StartupPath.Substring(0, len);
                pictureBox1.Image.Save(newpath + "image/" + newfnm);
                MessageBox.Show("Image Successfully Uploaded..!");
                pictureBox1.Image = null;
                btnupload.Text = "Image Upload";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            btnupload.Text = "Image Upload";
        }
    }
}
