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
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");  //Ado.Net gore sql baglantı kuruldu
        DataSet dataSet = new DataSet(); //dataları gecıcı olarak tutuyoruz.
        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {
            KayitGoster();//metot haline getirdim
        }

        private void KayitGoster()
        {
            baglanti.Open();//baglantı acıldı
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Musteri", baglanti); //geci dosyada sql de verileri cagırdım  
            dataAdapter.Fill(dataSet, "Musteri"); //geci dosayaya aktardım
            dataGridView1.DataSource = dataSet.Tables["Musteri"]; //grid de cagırıyorum
            baglanti.Close();//baglantı kapattım
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //buarası datagrideki verileri textlerde göstermek icin kullanılır.
            txtTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteri set AdSoyad=@AdSoyad,Telefon=@Telefon,Adres=@Adres,Email=@Email where TC=@TC ",baglanti);//tc göre guncelle verileri
            komut.Parameters.AddWithValue("@TC", txtTc.Text); //sql de ki verileri textler de cağırıyorum
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery(); //veri varsa cagır
            baglanti.Close(); //bagalantı sonlandı
            dataSet.Tables["Musteri"].Clear();//temizle islemi yapılır
            KayitGoster();//sonra kayıt goster metodundakı verileri goster.
            MessageBox.Show("Musteri  Guncellemiştir.");

            foreach (Control item in this.Controls) //bu formdakı kontrolleri git tek tek dolaş
            {
                if (item is TextBox) //eger item da textbox var ise 
                {
                    item.Text = ""; //icindekileri bosalat
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteri where tc='" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "'",baglanti); //tc gore silme işlemi yap
            komut.ExecuteNonQuery();//cagırma ıslemını yaptım
            baglanti.Close(); //baglantıyı kapattım 
            dataSet.Tables["Musteri"].Clear();//temizle islemi yapılır
            KayitGoster();//sonra kayıt goster metodundakı verileri goster.
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtTCARA_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Musteri where TC like '%" + txtTCARA.Text + "%'",baglanti);
            dataAdapter.Fill(table);//kayıtları tablo yap
            dataGridView1.DataSource = table;//tabloyu cagırdım
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
