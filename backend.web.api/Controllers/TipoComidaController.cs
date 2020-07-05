using DataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend.web.api.Controllers
{
    public class TipoComidaController : ApiController
    {
        RecommendationAppDBEntities BD = new RecommendationAppDBEntities();

        [HttpGet]
        public IEnumerable<TIPO_COMIDA> Get()
        {
            var list = BD.TIPO_COMIDA.ToList();
            return list;
        }

        [HttpGet]
        public TIPO_COMIDA Get(int id)
        {
            var meal = BD.TIPO_COMIDA.FirstOrDefault(x => x.tipoID == id);
            return meal;
        }
    }
}
