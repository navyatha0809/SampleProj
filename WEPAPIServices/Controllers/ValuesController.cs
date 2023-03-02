using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;

using System.Web.Http.Cors;
using WEPAPIServices.BuObjects;

namespace WEPAPIServices.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        DAL objDAl = new DAL();
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        [Route("GetDtails")]
        [HttpGet]
        public List<BusinessObjects> GetDtails()
        {
            try

            {
                DataTable t = new DataTable();
                t = objDAl.GetTableDetails();
                List<BusinessObjects> list = new List<BusinessObjects>();
                if (t.Rows.Count > 0)
                {
                    foreach (DataRow rdr in t.Rows)
                    {
                        BusinessObjects obj = new BusinessObjects();
                        obj.ID = Convert.ToInt32(rdr["Id"]);
                        obj.Name = rdr["Name"].ToString().Trim();
                        obj.Gender = rdr["Gender"].ToString().Trim();
                        obj.Salary = rdr["Salary"].ToString();
                        list.Add(obj);

                    }
                }

                return list;



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [Route("GetImagePaths")]
        [HttpGet]
        public List<imagepathObjetcs> GetImagePaths(int ID)
        {
            try
            {
                DataTable t = new DataTable();
                t = objDAl.Getimagepathes(ID);
                List<imagepathObjetcs> list = new List<imagepathObjetcs>();
                if (t.Rows.Count > 0)
                {
                    foreach (DataRow rdr in t.Rows)
                    {
                        imagepathObjetcs obj = new imagepathObjetcs();
                        obj.ID = Convert.ToInt32(rdr["ID"]);
                        obj.ImagePath = rdr["ImagePath"].ToString();
                       
                        list.Add(obj);

                    }
                }

                return list;



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
