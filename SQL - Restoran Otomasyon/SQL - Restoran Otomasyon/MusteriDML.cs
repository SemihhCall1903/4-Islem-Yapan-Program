using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AnaEkran
{
        class MusteriDML
        {
            public void MusteriLogKontrol()
            {
                PersonelGiris.conn.Open();



                PersonelGiris.conn.Close();
            }

            public void MusteriKayit()
            {
                PersonelGiris.conn.Open();

                Entity enClass = new Entity();

                SqlCommand mKayit = new SqlCommand("INSERT INTO tbl_restoran_musteriler(RestoranMusteriAd,RestoranMusteriSoyad) VALUES('" + enClass.ad + "','" + enClass.soyad + "')", PersonelGiris.conn);
                mKayit.ExecuteNonQuery();

                PersonelGiris.conn.Close();
            }
        }
}

