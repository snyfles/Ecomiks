using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ecomiks1.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaID { get; set; }

        [Required(ErrorMessage = "Preencha com o seu Nome")]
        [DisplayName("Nome da Pessoa")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Preencha com o seu RG")]
        //[DisplayName("RG")]
        //[StringLength(13, MinimumLength = 9, ErrorMessage = "O nome deve ter entre 9 e 13 caracteres.")]
        public string RG { get; set; }

        //[Required(ErrorMessage = "Preencha com o sua data de nascimento")]
        //[DisplayName("Date de Nascimento")]
        //[StringLength(22, MinimumLength = 8, ErrorMessage = "A data de nascimento deve ter entre 8 e 22 caracteres.")]
        public string DataNascimento { get; set; }

        //[Required(ErrorMessage = "Preencha com o seu CPF")]
        //[DisplayName("CPF")]
        //[StringLength(14, MinimumLength = 10, ErrorMessage = "O CPF deve ter entre 10 e 14 caracteres.")]
        public string CPF { get; set; }


        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Rua { get; set; }
        public string NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataHoraCadastro { get; set; }
        public string SenhaAcesso { get; set; }


        public int PerfilID { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}