using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASayasingMc_1Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        public List<string> nameList = new();
            
        [HttpPost]
        [Route("AddName/{nameToAdd}")]
        public List<string> NameToAddList(string nameToAdd) //Here
        {
            nameList.Add("Hello, " + nameToAdd);
            return nameList;
        }
    }
}
