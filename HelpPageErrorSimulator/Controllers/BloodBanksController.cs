using System.Collections.Generic;
using System.Web.Http;
using BloodBanks.Models;

namespace HelpPageErrorSimulator.Controllers
{
    public class BloodBanksController : ApiController
    {
        // GET: api/BloodBanks
        public IEnumerable<Bank> Get()
        {
            return new Bank[] { new Bank(), new Bank() };
        }

        // GET: api/BloodBanks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BloodBanks
        public void Post([FromBody]Bank value)
        {
        }

        // PUT: api/BloodBanks/5
        public void Put(int id, [FromBody]Bank value)
        {
        }

        // DELETE: api/BloodBanks/5
        public void Delete(int id)
        {
        }
    }
}
