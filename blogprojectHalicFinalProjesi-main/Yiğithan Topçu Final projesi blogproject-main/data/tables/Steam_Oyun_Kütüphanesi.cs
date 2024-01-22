using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class Steam_Oyun_Kütüphanesi
    {
        private int _id;
        [Key]
        public int id { get; set; }
        public string oyun { get; set; }
        public double oynanan_saat { get; set; }
        public int kazanilan_basarim { get; set; }

    }
}