using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL___Restoran_Otomasyon
{
    class MusteriKontrol
    {

        public bool KontrolEt(string musteriID)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAB5-OGRETMEN;Initial Catalog=semihardacalli1187VT;User ID=semiharda1187;Password=semih1903.");


            conn.Open();

            SqlCommand kontrol = new SqlCommand("SELECT RestoranMusteriAd,RestoranMusteriSoyad FROM tbl_restoran_musteriler WHERE RestoranMusteriIdPk = '" + musteriID + "'", conn);
            SqlDataReader oku = kontrol.ExecuteReader();

            while (oku.Read())
            {
                if (oku["RestoranMusteriIdPk"].ToString() == musteriID.ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            conn.Close();
            return false;

            
            
        }


    }
}
