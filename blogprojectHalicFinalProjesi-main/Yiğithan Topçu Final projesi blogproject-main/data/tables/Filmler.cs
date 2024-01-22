using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class Filmler
    {
        private int _id;
        [Key]
        public int id { get; set; }
        public string film { get; set; }
        public string türü { get; set; }
        public int saat { get; set; }

    }
}