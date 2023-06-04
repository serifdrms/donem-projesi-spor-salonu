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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SporSalonu
{





   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server = .; Database =sporsalonu; Initial Catalog=sporsalonu;Integrated Security=True");

        
        private void verigoruntule()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from sporsalonu", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["uyeno"].ToString());
                ekle.SubItems.Add(oku["tckimlik"].ToString());
                ekle.SubItems.Add(oku["tel"].ToString());
                ekle.SubItems.Add(oku["bas"].ToString());
                ekle.SubItems.Add(oku["bit"].ToString());


                listView1.Items.Add(ekle);
                


            }
            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox9.Hide();
            textBox13.Hide();
            verigoruntule();
            //textBox6.Hide();
            //textBox7.Hide();
            //textBox8.Hide();
            button5.Hide(); 
            //textBox10.Hide();
            //textBox11.Hide();
            //textBox12.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox7.Text + "." + textBox6.Text + "." + textBox8.Text;
            textBox13.Text = textBox11.Text + "." + textBox10.Text + "." + textBox12.Text;
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into sporsalonu (ad,soyad,uyeno,tckimlik,tel,bas,bit)values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox9.Text.ToString() + "','" + textBox13.Text.ToString() + "')", baglan) ;
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("ÜYE BAŞARIYLA EKLENDİ.");
            listView1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
           // textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox13.Clear();
            verigoruntule();
        }

     

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Clear();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /////////////////////////////
            //ÜYE SİLME İŞLEMİ
            /////////////////////////////
            ///


            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Delete from sporsalonu where uyeno=(" + textBox3.Text + ")", baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("ÜYE SİLİNDİ");

                baglan.Close();
                listView1.Items.Clear();
                verigoruntule();
               
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("ÜYE SİLME BAŞARISIZ.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///////////////////////
           //ÜYE DÜZENLEME İŞLEMİ
            ////////////////////////
            textBox9.Text = textBox7.Text + "." + textBox6.Text + "." + textBox8.Text;
            textBox13.Text = textBox11.Text + "." + textBox10.Text + "." + textBox12.Text;
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(" Update sporsalonu set ad='" + textBox1.Text.ToString() + "',soyad='" + textBox2.Text.ToString() + "',uyeno='" + textBox3.Text.ToString() + "',tckimlik='" + textBox4.Text.ToString() + "',tel='" + textBox5.Text.ToString() + "'where uyeno =" + textBox3.Text + "", baglan);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Başarıyla düzenlendi.");
                listView1.Items.Clear();
                verigoruntule();
                //Evet derse yapılacak işlemler
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
                MessageBox.Show("ÜYE DÜZENLEME BAŞARISIZ.");
                baglan.Close();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //////////////////////////////////////////////
            //VERİTABANINI LISTVIEW ARACINDA GÖRÜNTÜLEME
            //////////////////////////////////////////////
            ///


            textBox9.Enabled= false;
            textBox13.Enabled= false;
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();


            textBox9.Show();
            textBox13.Show();
            button5.Show();

            textBox10.Hide();
            textBox11.Hide();
            textBox12.Hide();
           
            textBox6.Clear();
            textBox7.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox9.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox13.Text = listView1.SelectedItems[0].SubItems[6].Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Enabled= false;
            textBox13.Enabled= false;
            textBox9.Hide();
            textBox13.Hide();
            textBox6.Show();
            textBox7.Show();
            textBox8.Show();

            textBox10.Show();
            textBox11.Show();
            textBox12.Show();
            

            textBox9.Text = textBox7.Text + "." + textBox6.Text + "." + textBox8.Text;
            textBox13.Text = textBox11.Text + "." + textBox10.Text + "." + textBox12.Text;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /////////////////
            //ÜYE ARAMA
            /////////////////
            ///

            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();

            textBox10.Hide();
            textBox11.Hide();
            textBox12.Hide();
        
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from sporsalonu where uyeno like '%" + textBox3.Text + "%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["uyeno"].ToString());
                ekle.SubItems.Add(oku["tckimlik"].ToString());
                ekle.SubItems.Add(oku["tel"].ToString());
                ekle.SubItems.Add(oku["bas"].ToString());
                ekle.SubItems.Add(oku["bit"].ToString());
      


                listView1.Items.Add(ekle);



            }
            baglan.Close();

        }

        private void TEMİZLE_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear ();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox9.Clear();
            textBox13.Clear();
        }

     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ///////////////////////////
            //TARİH DÜZENLEME
            ///////////////////////////
            ///


            textBox9.Text = textBox7.Text + "." + textBox6.Text + "." + textBox8.Text;
            textBox13.Text = textBox11.Text + "." + textBox10.Text + "." + textBox12.Text;
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand(" Update sporsalonu set bas='" + textBox9.Text.ToString() + "',bit='" + textBox13.Text.ToString() + "'where uyeno =" + textBox3.Text + "", baglan);

                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Başarıyla düzenlendi.");
                listView1.Items.Clear();
                verigoruntule();
                //Evet derse yapılacak işlemler
            }
            else if (secenek == DialogResult.No)
            {
                //Hayır derse yapılacak işlemler
                MessageBox.Show("Tarih düzenleme BAŞARISIZ.");
                baglan.Close();
            }
        }
    }
    }

