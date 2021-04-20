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

namespace WinFormsTestAsync
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

        private void button1_Click(object sender, EventArgs e)
        {
            Method();
            //Close();
        }

        private async void Method()
        {
            await Task.Run(() =>
            {
                while (File.Exists(@"C:\Users\kv1to\Desktop\Реквизиты жатки.txt"))
                {
                    button1.Text = "Loaded";
                }
            }
            );
        }
    }
}
