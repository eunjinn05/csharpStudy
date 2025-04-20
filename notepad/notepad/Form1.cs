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

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "(*.txt)|*.txt";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = saveFileDialog.FileName;
            saveFileDialog.OverwritePrompt = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOp = new OpenFileDialog();
            myOp.DefaultExt = "txt";
            myOp.InitialDirectory = ".";
            myOp.Filter = "(*.txt)|*.txt";

            if(myOp.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(myOp.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
