using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {   

        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection("Provider=")
            private object tablo;
        private int i;
        private DataTable tablo2;

        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr=new SqlDataAdapter("select *from kayitbilgileri",baglanti);
             adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form2_Load1(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stokbilgileri(stokadi,stokmodeli,serino,stokadedi,kayıtyapan)valuess('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',baglanti)");
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt eklendi","Kayıt");
            tablo.Clear();
            listele();

            for (int i = 0; i < Controls.Count; i++)
            {
                if(Controls]) is TextBox);
            {
                Controls[i].Text = "";
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete ,baglanti)");
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi", "Kayıt");
            tablo.Clear();
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select , baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["stokadi"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["stokmodeli"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["stokserino"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["stokadedi"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["kayityapan"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update kayitbilgileri set stokadi='"+textBox1.Text+ "', stokmodeli='" + textBox2.Text + "', stokserino='" + textBox3.Text + "', stokadedi='" + textBox4.Text + "', kayityapan='" + textBox5.Text + "',,baglanti)");
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi", "Kayıt");
            tablo.Clear();
            listele();

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls]) is TextBox);
            {
                Controls[i].Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select , baglanti);
            DataTable tablo2 = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            {

                DialogResult Cikis;
                Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
                if (Cikis == DialogResult.Yes)
                {
                    Application.Exit();
                }
                if (Cikis == DialogResult.No)
                {
                    Application.Run();
                }

            }

        }
    }
 }
 
