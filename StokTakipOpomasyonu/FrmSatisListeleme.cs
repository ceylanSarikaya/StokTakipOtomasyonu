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
    public partial class FrmSatisListeleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ALFA-BILGISAYAR;Initial Catalog=StokTakip;Integrated Security=True;Pooling=False");
        DataSet dataSet = new DataSet(); //vrieri gecici olaraka tutuyo

        private void SatısListele()//metoto olusturuldu
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Satis", baglanti);
            adapter.Fill(dataSet, "Satis");//sepet tablosundakı verileri daset de geci olarak tut
            dataGridView1.DataSource = dataSet.Tables["Satis"];//dataset verileri datagrid goster dıyorum.
           
            baglanti.Close();

        }
        public FrmSatisListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSatisListeleme_Load(object sender, EventArgs e)
        {
            SatısListele();
        }
    }
}
