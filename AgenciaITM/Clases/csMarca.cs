using AgenciaITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaITM.Clases
{
	public class csMarca
	{
        private AgenciaITM_BDEntities1 agenciaDB = new AgenciaITM_BDEntities1();

        public Marca marca { get; set; }

        public string Insertar()
        {
            try
            {
                agenciaDB.Marcas.Add(marca);
                agenciaDB.SaveChanges();
                return "Marca Agregado";
            }
            catch (Exception ex)
            {
                return "No se agrego";
            }
        }
    }
}