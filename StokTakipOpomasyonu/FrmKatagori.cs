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
    public partial class FrmKatagori : Form
    {
        public FrmKatagori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        //Ado.Net gore sql baglantı kuruldu
        bool durum;
        private void kategoriEngelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KategoriBilgileri", baglanti);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (textBox1.Text == dataReader["Kategori"].ToString() || textBox1.Text=="") 
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void FrmKatagori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriEngelle();
            if (durum==true)
            {
                baglanti.Open();//Baglantı acıldı
                SqlCommand komut = new SqlCommand("insert into KategoriBilgileri(Kategori) values('" + textBox1.Text + "')", baglanti);//dataya urun eklendı
                komut.ExecuteNonQuery();//cagırıldı
                baglanti.Close();//baglantı kapatıldı
                MessageBox.Show("Kategori Eklendi");//mesaj eklendi
            }
            else
            {
                MessageBox.Show("Boyle bir kategori var","Uyarı");
            }

            textBox1.Text = "";//texttin ici silindi

           
        }
    }
}
