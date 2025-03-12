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
    [RoutePrefix("api/Vehiculos")]
    public class VehicleController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vehiculo> ConsultarTodos()
        {
            csVehiculo vehiculo = new csVehiculo();
            return vehiculo.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public Vehiculo Consultar(int id)
        {
            csVehiculo vehiculo = new csVehiculo();
            return vehiculo.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vehiculo vh)
        {
            csVehiculo vehiculo = new csVehiculo();
            vehiculo.vehiculo = vh;
            return vehiculo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vehiculo vh)
        {
            csVehiculo vehiculo = new csVehiculo();
            vehiculo.vehiculo = vh;
            return vehiculo.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vehiculo vh)
        {
            csVehiculo vehiculo = new csVehiculo();
            vehiculo.vehiculo = vh;
            return vehiculo.Eliminar();
        }
    }
}