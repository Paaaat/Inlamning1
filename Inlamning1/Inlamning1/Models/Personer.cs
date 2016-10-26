using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1.Models
{
    public class Personer
    {
        public int PersonerId { get; set; }
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }
        public string Födelsedag { get; set; }
        // public virtual List<Personer> Folk { get; set; }
    }
}