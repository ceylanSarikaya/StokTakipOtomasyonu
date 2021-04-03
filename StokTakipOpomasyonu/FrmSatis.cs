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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");//veri tabanına baglanıldı
        DataSet dataSet = new DataSet();//gecici veri tutma oluşturuldu

        private void SepetListele()//metoto olusturuldu
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Sepet", baglanti);
            adapter.Fill(dataSet, "Sepet");//sepet tablosundakı verileri daset de geci olarak tut
            dataGridView1.DataSource = dataSet.Tables["Sepet"];//dataset verileri datagrid goster dıyorum.
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();

        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkleme listeleme = new FrmMusteriEkleme();
            listeleme.ShowDialog();
            //Musteri Ekleme sayfasını newleyip icindeki verileri burda  cağırıyoruz ekle atıyoruz 
             //ekle ile geciş sa ShowDiolog diyerek geciş işlemleri yapılır  aynı  işlemler aşagıda yapılır.


        }

        private void btnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme listele = new FrmMusteriListeleme();
           listele.ShowDialog();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkleme ekle = new FrmUrunEkleme();
            ekle.ShowDialog();
        }

        private void btnUrunListeleme_Click(object sender, EventArgs e)
        {
            FrmUrunListeleme ekle = new FrmUrunListeleme(); //Musteri Ekleme sayfasını newleyip icindeki verileri burda  cağırıyoruz ekle atıyoruz 
            ekle.ShowDialog();                                          //ekle ile geciş sa ShowDiolog diyerek geciş işlemleri yapılır  aynı  işlemler aşagıda yapılır.
        }

        private void btnSatisleriListele_Click(object sender, EventArgs e)
        {
            FrmSatisListeleme listeleme = new FrmSatisListeleme();
            listeleme.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            FrmMarka frmMarka = new FrmMarka();
            frmMarka.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKatagori frmKatagori = new FrmKatagori();
            frmKatagori.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteri Tc like '" + txtTc.Text + "'", baglanti); //Musteri tablosundakını tc gore getir.
            SqlDataReader read = komut.ExecuteReader();//kayıtları oku 
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtTelefon.Text = read["Telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Yenile();//yenile metodunu cagır 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Urun where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);//barkodNo  ya gore verileri getir
            SqlDataReader read = komut.ExecuteReader();//kayıtları oku 
            while (read.Read())
            {
                txtUrunAdi.Text = read["UrunAdi"].ToString();
                txtSatisFiyati.Text = read["SatisFiyat"].ToString();
            }
            baglanti.Close(); 
    
        }
        private void Yenile()
        {
            if (txtBarkodNo.Text == "")//eger txt deki barkod no bos ise
            {
                foreach (Control item in groupBox2.Controls) //git gorupbox kontrol et 
                {
                    if (item is TextBox)  
                    {
                        if (item != txtMiktar)//item textbox eşit degil ise 
                        {
                            item.Text = ""; //item.text di bos gonder.
                        }
                    }

                }
            }
        }
        bool durum; //bool false yada true ise 
        private void BarkodKontrol()
        {
            durum = true; //durum dogru ise 
            baglanti.Open(); //baglantıyı ac
            SqlCommand komut = new SqlCommand("select * from Sepet ", baglanti); //sepette verileri getir 
            SqlDataReader dataReader = komut.ExecuteReader(); //verileri oku 
            while (dataReader.Read())
            {
                if (txtBarkodNo.Text==dataReader["BarkodNo"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();//metot cagır 
            if (durum==true )
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Sepet(Tc,AdSoyad,telefon,barkodNo,UrunAdi,miktar,satisFiyati,ToplamFiyat,Tarih) values (@Tc, @AdSoyad,@telefon,@barkodNo,@UrunAdi,@miktari,@satisFiyat,@ToplamFiyat,@Tarih)", baglanti); //bunu sepet datama eklmesini yap 
                komut.Parameters.AddWithValue("@Tc", txtTc.Text); //yukarda data ıcın olusturdugum degeri texte gonder 
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@UrunAdi",txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));//int.Prase sayısal ıfadeye cevırmek ıcın kullanılır
                komut.Parameters.AddWithValue("@satisFiyat", double.Parse(txtSatisFiyati.Text));//ondalıklı sayıya cevirdim
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());//ekledıgım zamana gore zamanı belırle 
                komut.ExecuteNonQuery();//işlemi onaylıyorum
                txtMiktar.Text = "1";
                baglanti.Close();//baglantıyı kapatıyorum
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Sepet set Miktar=Miktar+'"+int.Parse(txtMiktar.Text)+ "' where barkodNo='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();//işlemi onaylıyorum
                SqlCommand komut3 = new SqlCommand("update Sepet set ToplamFiyat=Miktar * SatisFiyati where barkodNo='"+txtBarkodNo.Text+"'", baglanti);
           
                komut3.ExecuteNonQuery();//işlemi onaylıyorum
                txtMiktar.Text = "1";
                baglanti.Close();//baglantıyı kapatıyorum
            }
            //dataSet.Tables["Sepet"].Clear();
            SepetListele();

            Hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try//null deger verdiğinde hata vermesin diye try bloguna koyuyoruz.
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();//ondalıklı olan mıktar ve satıs fıyatı carp
            }
            catch (Exception)
            {

                //throw;
            }
     
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try//null deger verdiğinde hata vermesin diye try bloguna koyuyoruz.
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();//ondalıklı olan mıktar ve satıs fıyatı carp
            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();//baglantı acıldı
            SqlCommand komut = new SqlCommand("delete from sepet where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);//datamdakı verileri cekrek silme işlemni gerceklestir. bunu barkod noya gore yap
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun sepeten cıkarıldı");
            dataSet.Tables["Sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);//datamdakı verileri cekrek silme işlemni gerceklestir. bunu tumu ıcın yap
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urunler sepeten cıkarıldı");
            dataSet.Tables["Sepet"].Clear();
            SepetListele();
            Hesapla();
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {

        }
        private void Hesapla()
        {
            try//null deger verdiğinde hata vermesin diye try bloguna koyuyoruz.
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(ToplamFiyat) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Satis(Tc,AdSoyad,telefon,barkodNo,UrunAdi,miktar,satisFiyati,ToplamFiyat,Tarih) values (@Tc, @AdSoyad,@telefon,@barkodNo,@UrunAdi,@miktari,@satisFiyat,@ToplamFiyat,@Tarih)", baglanti); //bunu sepet datama eklmesini yap 
                komut.Parameters.AddWithValue("@Tc", txtTc.Text); //yukarda data ıcın olusturdugum degeri texte gonder 
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodNo", dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@UrunAdi", dataGridView1.Rows[i].Cells["UrunAdi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));//int.Prase sayısal ıfadeye cevırmek ıcın kullanılır
                komut.Parameters.AddWithValue("@satisFiyat", double.Parse(dataGridView1.Rows[i].Cells["SatisFiyati"].Value.ToString()));//ondalıklı sayıya cevirdim
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();//işlemi onaylıyorum
                txtMiktar.Text = "1";

                SqlCommand komut2 = new SqlCommand("update Urun set Miktar=Miktar -'" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "' where BarkodNo ='" + dataGridView1.Rows[i].Cells["barkodNo"].Value.ToString() + "' ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();//baglantıyı kapatıyorum

              
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti); //datayı sil
            komut3.ExecuteNonQuery();
            baglanti.Close();
            SepetListele();
            Hesapla();
        }
    }
}
