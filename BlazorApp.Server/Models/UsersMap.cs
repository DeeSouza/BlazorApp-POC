using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace BlazorApp.Server.Models
{
    public class UsersMap : ClassMap<Users>
    {
        public UsersMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Email);
            Map(x => x.Sexo);
            Map(x => x.Curso);
            Table("Users");
        }
    }
}
