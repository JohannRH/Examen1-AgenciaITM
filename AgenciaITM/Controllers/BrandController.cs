using AgenciaITM.Clases;
using AgenciaITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgenciaITM.Controllers
{
    [RoutePrefix("api/Marca")]
    public class BrandController : ApiController
    {
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Marca mc)
        {
            csMarca marca = new csMarca();
            marca.marca = mc;
            return marca.Insertar();
        }
    }
}