using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "yönetici" && textBox2.Text == "123") // burada if kullanarak kullanıcı adı ve şifrenin kontrolüne göre giriş yapılması için kontrol ediyorum
            {                                                         
                    MessageBox.Show("Giriş Başarılı");   //doğru ise ilk önce giriş başarılı 
                    MessageBox.Show("Hoşgeldiniz");      //sonrada hoşgeldiniz mesajını yazdırıyorum
                }
                else             //burada yanlış olan durum için yazdırması gereken mesajı istiyorum
                {
                    MessageBox.Show("Hatalı Giriş");      //ilk önce hatalı giriş   
                    MessageBox.Show("Tekrar Deneyiniz");     // sonrada tekrar deneyiniz mesajıyla şifre ve kullanıcı adının tekrar girilmesi istendi
            }
            Form2 frm2 = new Form2();        //giriş başarılı olduktan sonra ikinci forma geçebilmek için bu kodu kullandım.
            frm2.ShowDialog();               //giriş başaarılı olduktan sonra 1.form kapanıcak ve 2.forma geçiş yapılacaktır.
        }
    }
}
