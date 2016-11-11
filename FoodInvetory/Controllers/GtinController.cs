using FoodInvetory.DAL;
using FoodInvetory.Data;
using FoodInvetory.Interfaces.DAL;
using FoodInvetory.Models;
using FoodInvetory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace FoodInvetory.Controllers
{
    public class GtinController : ApiController
    {
        IGtinRepository repository;
        
        public GtinController()
        {
            this.repository = new GtinRepository();
        }

        // GET: api/Gtin
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Gtin/5
        public JsonResult<Gtin> Get(string id)
        {
            var gtin = this.repository.GetSingleGtin(id);
            
            return Json(gtin);
        }

        // POST: api/Gtin
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gtin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gtin/5
        public void Delete(int id)
        {
        }
    }
}
