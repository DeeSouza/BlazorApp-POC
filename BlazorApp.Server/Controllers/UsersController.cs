using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorApp.Server.Models;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public Array Get()
        {
            using (var session = NHibernateHelpers.OpenSession())
            {
                var users = session.Query<Users>();
                return users.ToArray();
            }
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Users Show(int id)
        {
            using (var session = NHibernateHelpers.OpenSession())
            {
                var user = session.Query<Users>().SingleOrDefault(i => i.Id == id);
                return user;
            }
        }
    }    
}
