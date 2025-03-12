using AgenciaITM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AgenciaITM.Clases
{
	public class csVehiculo
	{
        private AgenciaITM_BDEntities1 agenciaDB = new AgenciaITM_BDEntities1();

        public Vehiculo vehiculo { get; set; }

        public string Insertar()
        {
            try
            {
                Marca mc = agenciaDB.Marcas.FirstOrDefault(m => m.id == vehiculo.idMarca);
                if (mc == null)
                {
                    return "Marca de vehiculo no existe";
                }

                agenciaDB.Vehiculos.Add(vehiculo);
                agenciaDB.SaveChanges();
                return "Vehiculo Agregado";
            }
            catch (Exception ex)
            {
                return "No se agrego";
            }
        }

        public string Actualizar()
        {
            Vehiculo vh = Consultar(vehiculo.id);
            if (vh == null)
                return "Vehiculo no existe";

            agenciaDB.Vehiculos.AddOrUpdate(vehiculo);
            agenciaDB.SaveChanges();
            return "Vehiculo actualizado";
        }

        public Vehiculo Consultar(int id)
        {
            Vehiculo vh = agenciaDB.Vehiculos.FirstOrDefault(v => v.id == id);
            return vh;
        }

        public List<Vehiculo> ConsultarTodos()
        {
            return agenciaDB.Vehiculos.ToList();
        }

        public string Eliminar()
        {
            try
            {
                Vehiculo vh = Consultar(vehiculo.id);
                if (vh == null)
                    return "Vehiculo no existe";

                agenciaDB.Vehiculos.Remove(vh);
                agenciaDB.SaveChanges();
                return "Vehiculo eliminado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}