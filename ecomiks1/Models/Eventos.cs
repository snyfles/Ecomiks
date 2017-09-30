using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;


namespace ecomiks1.Models
{
    public class Eventos
    {
        [Key]
        public int eventoID { get; set; }
        public string eventoNome { get; set; }
        public string eventoDescricao { get; set; }
        public DateTime eventoData { get; set; }

    }
}