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
using System.IO;

namespace OperatingSystemReal
{
    public partial class Form2 : Form
    {
        string fileloc;
        public Form2()
        {
            InitializeComponent();
            this.button19.Hide();
            fileloc = @"D:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button19.Show();
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
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            this.button19.Show();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "shutdown";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = false;
            psi.Arguments = string.Format(@"-h");
            psi.UseShellExecute = false;

            Process process = Process.Start(psi);
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button19.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox1.Show();
            this.button4.Hide();
            this.button5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
            this.button4.Show();
            this.button5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.groupBox2.Show();
            this.button6.Hide();
            this.button7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.groupBox2.Hide();
            this.button6.Show();
            this.button7.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.groupBox3.Show();
            this.button14.Hide();
            this.button15.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.groupBox3.Hide();
            this.button14.Show();
            this.button15.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\Left4Dead\Left 4 Dead.exe");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\Steam.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\WarCraft III DOTA\Frozen Throne.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\Plants vs. Zombies\PlantsVsZombies.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\Prototype\Prototypef.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Games\Max Payne 2\MaxPayne2.exe");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Word 2010");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Excel 2010");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft PowerPoint 2010");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.button19.Hide();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(textBox1.Text + "\\" + textBox2.Text))
                {
                    Directory.CreateDirectory(textBox1.Text + "\\" + textBox2.Text);
                    MessageBox.Show("Folder Created");
                    this.pictureBox2.Show();
                }
                else
                {
                    MessageBox.Show( "Error Creating Folder");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Creating Folder", "Error Created File");

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {

                FolderBrowserDialog bw = new FolderBrowserDialog();
                bw.ShowDialog();
                if (bw.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = bw.SelectedPath;
                }
            }
            catch (Exception)
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(textBox1.Text + "\\" + textBox3.Text))
                {
                    File.Create(textBox1.Text + "\\" + textBox3.Text);
                    MessageBox.Show("File Created");
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Process.Start(textBox1.Text);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(textBox1.Text + "\\" + textBox5.Text);
                MessageBox.Show("Delete Folder Success");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccess");

            }
            catch (ArgumentException)
            {
                MessageBox.Show("UnauthorizedAccess");

            }
            catch (IOException)
            {
                MessageBox.Show("UnauthorizedAccess");
               
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(textBox1.Text + "\\" + textBox4.Text);
                MessageBox.Show("Complete Deleting Proccess");
            }

            
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccess");

            }
            
           
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.button25.Hide();
            this.groupBox4.Show();
            this.button27.Show();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.button26.Hide();
            this.groupBox5.Show();
            this.button28.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.button27.Hide();
            this.groupBox4.Hide();
            this.groupBox5.Hide();
            this.pictureBox2.Hide();
            this.button25.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.button28.Hide();
            this.groupBox5.Hide();
            this.button26.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.button29.Hide();
            this.groupBox6.Show();
            this.button42.Show();
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.button42.Hide();
            this.button29.Show();
            this.groupBox6.Hide();
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(fileloc + "\\" + textBox6.Text ))
                {
                    label2.Text = textBox6.Text;
                    Directory.CreateDirectory(fileloc + "\\" + textBox6.Text);
                    MessageBox.Show("Folder has been Created");
                    label2.Show();
                    pictureBox3.Show();
                }
                else
                {
                    MessageBox.Show("Folder has been created recently");
                }
                label1.Hide();
                button43.Hide();
                textBox6.Hide();

            }
            catch (Exception)
            {
                
                
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (fileloc != "") 
            {
                Process.Start(fileloc + "\\" + textBox6.Text);
            }

        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            label1.Show();
            textBox6.Show();
            button43.Show();

            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Form2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            label1.Show();
            textBox6.Show();
            button43.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now a Developer !");
            this.button48.Hide();
            this.button49.Show();
            this.button44.Show();
            this.button45.Show();
            this.button46.Show();
            this.button47.Show();
            this.textBox7.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer Option Off !");
            this.button48.Show();
            this.button49.Hide();
            this.button44.Hide();
            this.button45.Hide();
            this.button46.Hide();
            this.button47.Hide();
            this.textBox7.Hide();
        }
    }
}
        

