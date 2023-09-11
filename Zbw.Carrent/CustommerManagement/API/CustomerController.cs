namespace Zbw.Carrent.CustomerManagement.Api
{
    using Zbw.Carrent.CustomerManagement.Api.Models;
    using Microsoft.AspNetCore.Mvc;
    using Zbw.Carrent.CustommerManagement.Domain;
    using ControllerBase = Microsoft.AspNetCore.Mvc.ControllerBase;
    using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;
    using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
    using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
    using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
    using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerResponse> Get()
        {
            var customers = _repository.GetAll();
            return customers.Select(x => new CustomerResponse(x.Id, x.CustomerNr, x.Name, null));
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerResponse Get(Guid id)
        {
            return null;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public CustomerResponse Post([FromBody] CustomerRequest value)
        {
            return null;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public CustomerResponse Put(Guid id, [FromBody] CustomerRequest value)
        {
            return null;
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
