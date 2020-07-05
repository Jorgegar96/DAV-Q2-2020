using DataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace backend.web.api.Controllers
{
    public class RestauranteController : ApiController
    {
        RecommendationAppDBEntities BD = new RecommendationAppDBEntities();
        
        [HttpGet]
        public IEnumerable<RESTAURANTES> Get()
        {
            var list = BD.RESTAURANTES.ToList();
            return list;
        }

        [HttpGet]
        public RESTAURANTES Get(int id)
        {
            var restaurant = BD.RESTAURANTES.FirstOrDefault(x => x.ID == id);
            return restaurant;
        }

        [HttpPost]
        public void Post([FromBody] RESTAURANTES restaurant)
        {            
            BD.RESTAURANTES.Add(restaurant);
            BD.SaveChanges();            
        }
       
        [HttpDelete]
        public RESTAURANTES Delete(int id)
        {
            var restaurant = BD.RESTAURANTES.Where(x => x.ID == id).FirstOrDefault();

            BD.Entry(restaurant).State = System.Data.Entity.EntityState.Deleted;
            BD.SaveChanges();

            return restaurant;
        }
    }
}
