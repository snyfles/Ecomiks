using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ecomiks1.Models
{
    public class Perfil
    {

        [Key]
        public int PerfilID { get; set; }

        [Required(ErrorMessage = "Preencha o nome do perfil")]
        [DisplayName("NomePerfil")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O nome do perfil deve ter entre 2 e 30 caracteres.")]
        public string NomePerfil { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }

    }
}