using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int baki = 1000;
       
        private void onayla_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(tus.Text);

           //if (ekran.Text == "Merhaba Şifrenizi Giriniz")      
                   // if (secim == 1234)
                   // {
                     // ekran.Text = "Hoşgeldiniz";
                     // tus.Text = "";
                   // }
        
            if (ekran.Text == "Yatırılacak tutarı giriniz")
               if (secim != 0)
                {
                ekran.Text = "Hesabınıza " + secim + " TL yatırdınız.\n"+ "Bakiyeniz "+ (baki += secim)+" TL";   
                }
            if (ekran.Text == "Çekilecek tutarı giriniz")
                if (secim != 0)
                {
                    if (secim <= baki)
                    {
                        ekran.Text = "Hesabınızdan " + secim + " TL çekildi.\n" + "Bakiyeniz " + (baki -= secim) + " TL";

                    } 
                    else
                    {
                        ekran.Text = "Yetersiz bakiye";
                    }
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void bakiye_Click(object sender, EventArgs e)
        {
            
            if (ekran.Text == "Hoşgeldiniz")
            {
                ekran.Text = Convert.ToString("Bakiyeniz "+baki + " TL");
                tus.Text = "";
            }
          
        
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            ekran.Text = "Çıkış Yaptınız Hoşçakalın";
        }

        private void parayatir_Click_1(object sender, EventArgs e)
        {
            if (ekran.Text == "Hoşgeldiniz")
            {
                ekran.Text = "Yatırılacak tutarı giriniz";

            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
           
            
                if (ekran.Text != "Çıkış Yaptınız Hoşçakalın")
            {   
                ekran.Text = "Hoşgeldiniz";
                tus.Text = "";
            }
         
        }

        private void paracek_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "Hoşgeldiniz")
            {
                ekran.Text = "Çekilecek tutarı giriniz";
                tus.Text = "";

            }
        }
    }
}
