using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videobutik.Models
{
    
    public class Kund
    {
        [Key]
        public int id { get; set; }
        public string fornamn { get; set; }
        public string efternamn { get; set; }
        public DateTime registerdatum { get; set; }
    }
}