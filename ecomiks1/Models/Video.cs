using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecomiks1.Models
{
    public class Video
    {
        public int videoID { get; set; }
        public string videoNome { get; set; }
        public string videoUrl { get; set; }
        public string videoDescricao { get; set; }
        public string videoCategoria { get; set; }
        public int videoAvaliacao { get;set; }
        
    }
}