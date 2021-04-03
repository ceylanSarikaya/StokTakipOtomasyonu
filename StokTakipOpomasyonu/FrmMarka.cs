using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOpomasyonu
{
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        //Ado.Net gore sql baglantı kuruldu
        bool durum;
        private void MarkaEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Marka", baglanti);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (comboBox1.Text==dataReader["Kategori"].ToString()&& textBox1.Text == dataReader["Marka"].ToString() || comboBox1.Text=="" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MarkaEngelle();
            if (durum==true)
            {
                baglanti.Open();//Baglantı acıldı
                SqlCommand komut = new SqlCommand("insert into Marka(Marka,Kategori) values('" + textBox1.Text + "','" + comboBox1.Text + "')", baglanti);//dataya urun eklendı
                komut.ExecuteNonQuery();//cagırıldı
                baglanti.Close();//baglantı kapatıldı
                MessageBox.Show("Marka Eklendi");//mesaj eklendi
            }
            else
            {
                MessageBox.Show("Boyle bır kategorı ve Marka var", "Uyarı");
            }
         
            textBox1.Text = "";//texttin ici silindi
            comboBox1.Text = "";//combobox ıcı temızledı
     

            baglanti.Close();

        }

        private void FrmMarka_Load(object sender, EventArgs e)
        {
            kategoriGetir();
        }

        private void kategoriGetir()
        {
            baglanti.Open();//baglantı acıldı
            SqlCommand komut = new SqlCommand("select * from KategoriBilgileri", baglanti); //kategorıde kı veriler cagırıldı
            SqlDataReader read = komut.ExecuteReader(); //data okutuldu
            while (read.Read())// kayıtlar okundugu surece 
            {
                comboBox1.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
    }
    }
