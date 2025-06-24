using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacilSD.Dominio.Modelo.Abstracciones;

namespace DulceFacilSD.Infraestructura.AccesoDatos.Repositorio
{
    public class RolesRepositorioImpl : RepositorioImpl<Roles>, IRolesRepositorio
    {
        public RolesRepositorioImpl(DulcefacilDistribucionContext dBcontext) : base(dBcontext)
        {
        }
    }
}
