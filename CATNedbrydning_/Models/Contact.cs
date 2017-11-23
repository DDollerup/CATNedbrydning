using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CATNedbrydning_.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}