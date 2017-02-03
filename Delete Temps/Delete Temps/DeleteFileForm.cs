﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace Delete_Temps
{
    public partial class DeleteFileForm : Form
    {
        public DeleteFileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            try
            {
                if (textBox3.Text == textBox2.Text) //input text and random text
                {
                    FileInfo[] arr = di.GetFiles();
                    foreach (FileInfo file in arr)
                    {
                        file.Delete();
                    }
                    MessageBox.Show("File Deleted");
                }
                else
                    MessageBox.Show("Input Right Random Password");
            }
            catch
            {
                throw new Exception("Input Rigt Random Password");
            }
           
        }
        string path;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            path = textBox1.Text;
            if (path != null)
            {
                double[] x = new double[3000];//Create array length(0-3000)
                Random rnd = new Random();//Random Function
                textBox3.Text = rnd.Next(1000, 3000).ToString();//Random Generate
            }
            else
            {
                return;
                    }
        }     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
        }

    }
}
