using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaEkran
{
    class Entity
    {
       public string EntityAd(string ad)
       {
           this.ad = "Semih Arda";
           return this.ad;
       }

       public string EntitySoyad(string soyad)
       {
           this.soyad = "Çallı";
           return this.soyad;

       }

       public string ad { get; set; }

       public string soyad { get; set; }
    }
}
