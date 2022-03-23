using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinfromDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\photo";
            if(Directory.Exists(path))
            {
                MessageBox.Show("Folder already exist");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("created");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\photo\camera.txt";
            if(File.Exists(path))
            {
                MessageBox.Show("Folder already exist");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("created");

            }

        }
    }
}
