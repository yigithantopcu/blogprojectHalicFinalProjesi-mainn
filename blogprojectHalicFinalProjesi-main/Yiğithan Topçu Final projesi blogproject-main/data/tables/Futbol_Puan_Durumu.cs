using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class Futbol_Puan_Durumu
    {
        private int _id;
        [Key]
        public string takim { get; set; }
        public int galibiyet { get; set; }
        public int beraberlik { get; set; }
        public int mağlubiyet { get; set; }
        public int puan { get; set; }
    }
}