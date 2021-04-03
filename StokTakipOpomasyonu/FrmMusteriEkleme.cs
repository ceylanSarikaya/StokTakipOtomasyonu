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
    public partial class FrmMusteriEkleme : Form
    {
        public FrmMusteriEkleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        //Ado.Net gore sql baglantı kuruldu
        private void FrmUrunListeleme_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //baglantı acıldı
            SqlCommand komut = new SqlCommand("insert into Musteri(TC,AdSoyad,Telefon,Adres,Email) values(@TC,@AdSoyad,@Telefon,@Adres,@Email)", baglanti); //sql datalar yazıldı ve dagelere atandı
            komut.Parameters.AddWithValue("@TC", txtTc.Text); //sql de ki verileri textler de cağırıyorum
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery(); //veri varsa cagır
            baglanti.Close(); //bagalantı sonlandı
            MessageBox.Show("Musteri Kaydı olusturuldu");

            foreach (Control item in this.Controls) //bu formdakı kontrolleri git tek tek dolaş
            {
                if (item is TextBox ) //eger item da textbox var ise 
                {
                    item.Text = ""; //icindekileri bosalat
                }
            }

        }
    }
}
