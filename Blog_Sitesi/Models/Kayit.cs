
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

using System.Linq;
using System.Threading.Tasks;

namespace Blog_Sitesi.Models
{
    public class Kayit
    {
        [key]
        public int id { get; set; }
        public string mail { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
