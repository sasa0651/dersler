using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }
        
        private void onay1_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(tus1.Text);
            if (secim == 1234) 
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            { 
                ekran1.Text = "Şifreniz Yanlış";
            }
        }
    }
}
