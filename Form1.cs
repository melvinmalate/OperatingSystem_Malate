using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace OperatingSystemReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button4.Hide();
        }
        int load = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.button4.Show();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@" -s -t 30");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button4.Show();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@" -r -t 30");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "mcos" && textBox2.Text == "09286007755")
            {
                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Error please use your mind !");
            }
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = load.ToString() + "%";
            pictureBox1.Show();
            load++;
            if (load == 102)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Hide();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"/a");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You are now a Developer !");
            this.button5.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Hide();
            this.button6.Show();
            this.textBox3.Show();
            this.textBox4.Show();
            this.textBox5.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Hide();
            this.textBox3.Hide();
            this.textBox4.Hide();
            this.textBox5.Hide();
        }
    }
}
