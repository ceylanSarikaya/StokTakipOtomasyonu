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
    public partial class FrmUrunEkleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Urun", baglanti);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                if (txtBarkod.Text == dataReader["BarkodNo"].ToString() || txtBarkod.Text=="") 
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        public FrmUrunEkleme()
        {
            InitializeComponent();
        }

        private void FrmUrunEkleme_Load(object sender, EventArgs e)
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
                comboKategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();//baglantı acıldı
            SqlCommand komut = new SqlCommand("select * from Marka where Kategori='"+comboKategori.SelectedItem+"'", baglanti); //kategorıde kı veriler cagırıldı
            SqlDataReader read = komut.ExecuteReader(); //data okutuldu
            while (read.Read())// kayıtlar okundugu surece 
            {
                comboMarka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Urun(BarkodNo,Kategori,Marka,UrunAdi,Miktar,AlisFiyat,SatisFiyat,Tarih) values(@BarkodNo,@Kategori,@Marka,@UrunAdi,@Miktar,@AlisFiyat,@SatiFiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkod.Text);
                komut.Parameters.AddWithValue("@Kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@Marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@UrunAdi", txtUrunad.Text);
                komut.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@AlisFiyat", double.Parse(txtAlisFiyat.Text));
                komut.Parameters.AddWithValue("@SatiFiyat", double.Parse(txtSatisFiyat.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("urun eklendi");
            }
            else
            {
                MessageBox.Show("Boyle bır barkod var", "Uyarı");
            }
          
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox )
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text=="")//eger barkodNo ıcı bos ıse 
            {
                lblMiktar.Text = "";//lable ıcını bosalt
                foreach (Control item in groupBox2.Controls)//foreach ile git group2 ıcınnı dolas
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Urun where BarkodNo like '"+txtBarkodNo.Text+"'", baglanti);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                Kategoritxt.Text = dataReader["Kategori"].ToString();
               Markatxt.Text = dataReader["Marka"].ToString();
               UrunAditxt .Text = dataReader["UrunAdi"].ToString();
                lblMiktar.Text = dataReader["Miktar"].ToString();
                Alistxt.Text = dataReader["AlisFiyat"].ToString();
                Satistxt.Text = dataReader["SatisFiyat"].ToString();
            }
            baglanti.Close();
        }

        private void btnVarEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Urun set Miktar=Miktar +'"+int.Parse(Miktartxt.Text)+"' where BarkodNo ='"+txtBarkodNo.Text+"' ",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)//foreach ile git group2 ıcınnı dolas
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan  urune ekleme yapıldı");
        }
    }
}
