using KendoMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KendoMvvm.Controllers
{
    public class RegistrationController : ApiController
    {
        [HttpPost]
        public void SaveEmployee([FromBody] Employee employee)
        {

        }
    }
}
