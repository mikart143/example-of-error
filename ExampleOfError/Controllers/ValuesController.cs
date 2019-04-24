using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleOfError.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ExampleOfError.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {



        // PUT api/values
        [HttpPut]
        public RefreshTokenForm Put( [FromBody] RefreshTokenForm form)
        {
            return form;
        }


    }
}
