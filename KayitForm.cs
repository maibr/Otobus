using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus
{
    public partial class KayitForm : Form
    {
        Form1 AnaForm;
        string KoltukNo;
        public KayitForm(Form1 frm, string koltukNo)
        {

            AnaForm = frm;
            InitializeComponent();
            txtKoltukNo.Text = koltukNo;
            txtKoltukNo.Enabled = false;
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AnaForm.DataGrideEkle(txtAdSoyad.Text, cmbCinsiyet.Text, txtKoltukNo.Text, txtFiyat.Text);
            switch (txtKoltukNo.Text)
            {
                case "1":
                    AnaForm.Button2ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "2":
                    AnaForm.Button3ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "3":
                    AnaForm.Button4ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "4":
                    AnaForm.Button5ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "5":
                    AnaForm.Button6ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "6":
                    AnaForm.Button7ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "7":
                    AnaForm.Button13ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "8":
                    AnaForm.Button12ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "9":
                    AnaForm.Button11ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "10":
                    AnaForm.Button10ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "11":
                    AnaForm.Button9ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "12":
                    AnaForm.Button8ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "13":
                    AnaForm.Button19ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "14":
                    AnaForm.Button18ChangeBackground(cmbCinsiyet.Text);
                    break;
                case "15":
                    AnaForm.Button17ChangeBackground(cmbCinsiyet.Text);
                    break;
                

                default:
                    break;
            }
            this.Close();
            //frm.DaGAdd("asd");
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
