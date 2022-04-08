using SQL___Restoran_Otomasyon;
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

namespace AnaEkran
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection("Data Source=LAB5-OGRETMEN;Initial Catalog=semihardacalli1187VT;User ID=semiharda1187;Password=semih1903.");

        public void button1_Click(object sender, EventArgs e)
        {
            Entity enClass = new Entity();

            enClass.ad = textBox1.Text;
            enClass.soyad = textBox2.Text;

            MusteriDML mDML = new MusteriDML();
            mDML.MusteriLogKontrol();

            MusteriKontrol musKon = new MusteriKontrol();
            string idKontrol = textBox3.Text;
            musKon.KontrolEt(idKontrol.ToString());
            conn.Close();

        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter listele = new SqlDataAdapter("SELECT RestoranMusteriIdPk AS 'Müsteri ID',RestoranMusteriAd AS 'Müşteri Soyad',RestoranMusteriSoyad AS 'Müşteri Soyad' FROM tbl_restoran_musteriler", PersonelGiris.conn);
            listele.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitOl kyt = new KayitOl();
            kyt.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonelGiris.conn.Open();

            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            PersonelGiris.conn.Close();
        }

       


    }
}
