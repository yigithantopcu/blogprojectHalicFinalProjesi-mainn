using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace data.tables
{
    public class Sehirler
    {
        [Key]
        private int _plaka { get; set; }
        public int id { get; set;}
        public string sehir_adi { get; set; }
        public int plaka { get; set; }
        public int nüfus { get; set; }
    }
}       
