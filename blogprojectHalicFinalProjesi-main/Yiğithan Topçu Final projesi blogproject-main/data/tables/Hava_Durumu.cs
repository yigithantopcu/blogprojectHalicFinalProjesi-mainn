using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class Hava_Durumu
    {
        [Key]
        private int _id;
        public int id { get; set; }
        public int tarih { get; set; }
        public string sehir { get; set; }
        public string durum { get; set; }
        public double sicaklik { get; set; }
        public int nem { get; set; }
    }
}