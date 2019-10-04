using CreditInfo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CreditInfo.Api.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
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

		//[ActionName("search")]
		[HttpGet]
		[Route("api/search/{nationalId}")]
		public string Search(string nationalId)
		{
			var hasIndividual = ContractLoader.HasIndividual(nationalId, Access.GetOpenConnection());
			return hasIndividual ? "single hit" : "no hit";
		}

		[HttpGet]
		[Route("api/detail/{nationalId}")]
		public IHttpActionResult Detail(string nationalId)
		{
			var detail = ContractLoader.LoadContractDetail(nationalId, Access.GetOpenConnection());
			return Ok(detail);
		}
	}
}
