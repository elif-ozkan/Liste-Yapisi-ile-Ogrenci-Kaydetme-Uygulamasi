using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_ile_Ögrenci_Kaydetme_Uygulaması
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
            List<string> kişiler = new List<string>();
            kişiler.Add("Mazhar");
            kişiler.Add("Ruhsar");
            kişiler.Add("Müfit");
            kişiler.Add("Reyhan");
            kişiler.Add("Fridevs");

            foreach(string k in kişiler)
            {
                listBox1.Items.Add(k);  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayılar = new List<int>();
            sayılar.Add(74);
            sayılar.Add(55);
            sayılar.Add(45);
            sayılar.Add(22);
            sayılar.Add(66);

            foreach(int s in sayılar)
            {
                if (s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Karakter> karakter = new List<Karakter>();

            karakter.Add(new Karakter()
            {
                ADI = "Salih",
                Soyad="Öztunç",
                Meslek="Ögretmen"




            }); 
            foreach(Karakter k in karakter)
            {
                listBox3.Items.Add(k.ADI+" "+k.Soyad+" "+k.Meslek);
            }
        }
    }
}
