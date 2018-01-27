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

namespace Otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            Class1 yolcularınkaydi = new Class1();

            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mydocpath = Environment.GetFolderPath
               (Environment.SpecialFolder.MyDocuments);

            StreamReader sr = new StreamReader(mydocpath + @"\WriteFile.txt");
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                string[] kolon = line.Split('|');
                dataGridView1.Rows.Add(kolon[0].Trim(), kolon[1].Trim(), kolon[2].Trim(), kolon[3].Trim(), kolon[4].Trim());
                if (Convert.ToInt32(kolon[2]) == 1)
                {
                    Button2ChangeBackground(kolon[1].Trim());
                }
                if (Convert.ToInt32(kolon[2]) == 2)
                {
                    Button3ChangeBackground(kolon[1].Trim());
                }
                line = sr.ReadLine();

            }
            sr.Close();

        }





        public void DataGrideEkle(string AdSoyad, string cinsiyet, string koltukNo, string Fiyat)
        {
            dataGridView1.Rows.Add(AdSoyad, cinsiyet, koltukNo, Fiyat, DateTime.Now.ToShortDateString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "1");
            kf.ShowDialog();
        }
        public void Button2ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button2.BackColor = Color.PowderBlue;
            }
            else
            {
                button2.BackColor = Color.Pink;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "2");
            kf.ShowDialog();
        }
        public void Button3ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "3");
            kf.ShowDialog();
        }
        public void Button4ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
           

            if (button4.BackColor != button3.BackColor)
            {
                MessageBox.Show("Koltuklardaki cinsiyet farklılığı saptandı. Devam etmek istiyor musunuz?" + "Uyarı" + MessageBoxButtons.YesNoCancel);
            }
            else
            {
                button3.Enabled = false;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "5");
            kf.ShowDialog();

        }
        public void Button6ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "4");
            kf.ShowDialog();
        }

        public void Button5ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "6");
            kf.ShowDialog();
        }
        public void Button7ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }

            if (button6.BackColor != button7.BackColor)
            {
                MessageBox.Show("Koltuklardaki cinsiyet farklılığı saptandı. Devam etmek istiyor musunuz?" + "Uyarı" + MessageBoxButtons.YesNoCancel);
            }
            else
            {
                button3.Enabled = false;
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "7");
            kf.ShowDialog();
        }
        public void Button13ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "8");
            kf.ShowDialog();
        }
        public void Button12ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "9");
            kf.ShowDialog();
        }
        public void Button11ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }

            if (button12.BackColor != button11.BackColor)
            {
                MessageBox.Show("Koltuklardaki cinsiyet farklılığı saptandı. Devam etmek istiyor musunuz?" + "Uyarı" + MessageBoxButtons.YesNoCancel);
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "10");
            kf.ShowDialog();
        }
        public void Button10ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "11");
            kf.ShowDialog();
        }
        public void Button9ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "12");
            kf.ShowDialog();
        }
        public void Button8ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }

            if (button9.BackColor != button8.BackColor)
            {
                MessageBox.Show("Koltuklardaki cinsiyet farklılığı saptandı. Devam etmek istiyor musunuz?" + "Uyarı" + MessageBoxButtons.YesNoCancel);
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "13");
            kf.ShowDialog();
        }
        public void Button19ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "14");
            kf.ShowDialog();
        }
        public void Button18ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }
            button3.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            KayitForm kf = new KayitForm(this, "15");
            kf.ShowDialog();
        }
        public void Button17ChangeBackground(string cinsiyet)
        {
            if (cinsiyet == "Erkek")
            {
                button3.BackColor = Color.PowderBlue;
            }
            else
            {
                button3.BackColor = Color.Pink;
            }

            if (button18.BackColor != button17.BackColor)
            {
                MessageBox.Show("Koltuklardaki cinsiyet farklılığı saptandı. Devam etmek istiyor musunuz?" + "Uyarı" + MessageBoxButtons.YesNoCancel);
            }
            else
            {
                button3.Enabled = false;
            }
        }
    }

}
