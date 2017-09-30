namespace ecomiks1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using ecomiks1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ecomiks1.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ecomiks1.Models.Context context)
        {
            IList<Perfil> perfils = new List<Perfil>();
            perfils.Add(new Perfil() { NomePerfil = "Comum" });
            perfils.Add(new Perfil() { NomePerfil = "Premium" });
            perfils.Add(new Perfil() { NomePerfil = "Anunciante" });
            perfils.Add(new Perfil() { NomePerfil = "Administrador" });

            foreach (Perfil perfil in perfils)
            {
                context.Perfils.AddOrUpdate(x => x.PerfilID, perfil);
            }
        }
    }
}
