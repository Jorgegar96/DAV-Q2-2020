using DataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend.web.api.Controllers
{
    public class UsuarioController : ApiController
    {
        RecommendationAppDBEntities BD = new RecommendationAppDBEntities();

        [HttpGet]
        public IEnumerable<USUARIOS> Get()
        {
            var list = BD.USUARIOS.ToList();

            return list;
        }

        [HttpGet]
        public USUARIOS Get(int id)
        {
            var user = BD.USUARIOS.FirstOrDefault(x => x.ID == id);
            return user;
        }
    }
}
