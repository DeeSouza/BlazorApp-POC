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
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public Array Get()
        {
            using (var session = NHibernateHelpers.OpenSession())
            {
                var users = session.Query<Users>();
                return users.ToArray();
            }
        }
    }
}
