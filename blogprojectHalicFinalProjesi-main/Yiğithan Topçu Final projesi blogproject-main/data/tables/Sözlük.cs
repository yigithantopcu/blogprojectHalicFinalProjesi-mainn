using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class Sözlük
    {
        private int _id;
        [Key]
        public int id { get; set; }
        public string ingilizce { get; set; }
        public string türkce { get; set; }
    }
}