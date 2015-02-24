using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelpPageErrorSimulator.Models;
using MoneyBanks.Models;

namespace HelpPageErrorSimulator.Controllers
{
    public class MoneyBanksController : ApiController
    {
        // GET: api/MoneyBanks
        public IEnumerable<Bank> Get()
        {
            return new Bank[] { new Bank(), new Bank() };
        }

        // GET: api/MoneyBanks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MoneyBanks
        public void Post([FromBody]Bank value)
        {
        }

        // PUT: api/MoneyBanks/5
        public void Put(int id, [FromBody]Bank value)
        {
        }

        // DELETE: api/MoneyBanks/5
        public void Delete(int id)
        {
        }
    }
}
