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

namespace Undertale_delete_save
{
    public partial class Form1 : Form
    {
        bool C;
        bool D;
        bool E;
        bool F;
        bool V;
        bool B;
        bool U;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "C")
            {
                lol();
                C = true;
            }
            else if (comboBox1.Text == "D")
            {
                lol();
                D = true;
            }
            else if (comboBox1.Text == "E")
            {
                lol();
                E = true;
            }
            else if (comboBox1.Text == "F")
            {
                lol();
                F = true;
            }
            else if (comboBox1.Text == "V")
            {
                lol();
                V = true;
            }
            else if (comboBox1.Text == "B")
            {
                lol();
                B = true;
            }
            else if (comboBox1.Text == "U")
            {
                lol();
                U = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (C == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if(D == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("D:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if (E == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("E:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if (F == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("F:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if (V == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("V:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if (B == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("B:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
                else if (U == true)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo("U:\\Users\\Дамир\\AppData\\Local\\UNDERTALE");
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }
            }
            catch { MessageBox.Show("Не получилось", "Undertale-delete-save", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void lol()
        {
            C = false;
            D = false;
            E = false;
            F = false;
            V = false;
            B = false;
            U = false;
        }
    }
}
