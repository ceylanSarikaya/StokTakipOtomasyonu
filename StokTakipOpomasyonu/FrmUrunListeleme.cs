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
    public partial class FrmUrunListeleme : Form
    {
        public FrmUrunListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        DataSet dataSet = new DataSet(); //vrieri gecici olaraka tutuyor
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
        private void FrmUrunListeleme_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategoriGetir();
        }

        private void UrunListele()
        {
            baglanti.Open(); //baglanti acılır 
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Urun ", baglanti); //baglantı data dan cagırılır
            dataAdapter.Fill(dataSet, "Urun"); //gecıcı dataya aktarılır
            dataGridView1.DataSource = dataSet.Tables["Urun"]; //datagrid de gosterilir
            baglanti.Close(); //baglantı kapatıldı
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            UrunAditxt.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            Miktartxt.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            Alistxt.Text = dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();
            Satistxt.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Urun set UrunAdi=@UrunAdi,Miktar=@Miktar,AlisFiyati=@AlisFiyati,SatisFiyati=@SatisFiyati where BarkodNo=@BarkodNo ", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo ", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@UrunAdi", UrunAditxt.Text);
            komut.Parameters.AddWithValue("@Miktar", int.Parse(Miktartxt.Text));
            komut.Parameters.AddWithValue("@AlisFiyati",double.Parse( Alistxt.Text));
            komut.Parameters.AddWithValue("@SatisFiyati", double.Parse(Satistxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["Urun"].Clear();
            UrunListele();
            MessageBox.Show("Guncelleme İslemi Gercekleşti");
            foreach (Control item in this.Controls) //bu formdakı kontrolleri git tek tek dolaş
            {
                if (item is TextBox) //eger item da textbox var ise 
                {
                    item.Text = ""; //icindekileri bosalat
                }

            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Urun set Kategori=@Kategori , Marka =@Marka where BarkodNo=@BarkodNo ", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo ", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@Kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@Marka", comboBox2.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Guncelleme İslemi Gercekleşti");
            }
            else
            {
                MessageBox.Show("BarkodNo Yazılı degil");
            }
         
            foreach (Control item in this.Controls) //bu formdakı kontrolleri git tek tek dolaş
            {
                if (item is TextBox) //eger item da textbox var ise 
                {
                    item.Text = ""; //icindekileri bosalat
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();//baglantı acıldı
            SqlCommand komut = new SqlCommand("select * from Marka where Kategori='" + comboBox1.SelectedItem + "'", baglanti); //kategorıde kı veriler cagırıldı
            SqlDataReader read = komut.ExecuteReader(); //data okutuldu
            while (read.Read())// kayıtlar okundugu surece 
            {
                comboBox2.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Urun where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti); //tc gore silme işlemi yap
            komut.ExecuteNonQuery();//cagırma ıslemını yaptım
            baglanti.Close(); //baglantıyı kapattım 
            dataSet.Tables["Urun"].Clear();//temizle islemi yapılır
            UrunListele();//sonra kayıt goster metodundakı verileri goster.
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Urun where BarkodNo like '%" + txtBarkodAra.Text + "%'", baglanti);
            dataAdapter.Fill(table);//kayıtları tablo yap
            dataGridView1.DataSource = table;//tabloyu cagırdım
            baglanti.Close();
        }
    }
}
