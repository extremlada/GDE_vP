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

namespace GDE_vP
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 button3 = new Form2();
            DialogResult result = button3.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("opened ok");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 

        private void button2_Click_1(object sender, EventArgs e)
        {
            var fileContent = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStrem = openFileDialog.OpenFile();
                richTextBox1 textBox = new RichTextBox1();


                textBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            

        }


    }
}
