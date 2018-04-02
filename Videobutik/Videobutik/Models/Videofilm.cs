using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videobutik.Models
{
    public class Videofilm
    {
        [Key]
        public string titel { get; set; }
        public int speltid { get; set; }
        public string rating { get; set; }
        public string genre { get; set; }
    }
}