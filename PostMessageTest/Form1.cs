using System;
using System.Windows.Forms;

namespace PostMessageTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Program.FindWindow("Shell_TrayWnd", null).ToString("x8");
            textBox2.Text = 0x05D1.ToString("x8");
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.PostMessageW((IntPtr)Convert.ToInt64(textBox1.Text, 16), Convert.ToUInt32(textBox2.Text, 16),
                (IntPtr)Convert.ToInt64(textBox3.Text, 16), (IntPtr)Convert.ToInt64(textBox4.Text, 16));
        }
    }
}