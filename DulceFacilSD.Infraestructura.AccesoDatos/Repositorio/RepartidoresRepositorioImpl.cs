using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacilSD.Dominio.Modelo.Abstracciones;

namespace DulceFacilSD.Infraestructura.AccesoDatos.Repositorio
{
    public class RepartidoresRepositorioImpl : RepositorioImpl<Repartidores>, IRepartidoresRepositorio
    {
        public RepartidoresRepositorioImpl(DulcefacilDistribucionContext dBcontext) : base(dBcontext)
        {
        }
    }
}
