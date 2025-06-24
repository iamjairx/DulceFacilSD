using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DulceFacilSD.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;

namespace DulceFacilSD.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly DulcefacilDistribucionContext _DBContext;
        private readonly DbSet<T> _dbset;

        public RepositorioImpl(DulcefacilDistribucionContext dBcontext) { 
            _DBContext = dBcontext;
            _dbset = dBcontext.Set<T>();
        }
        public async Task Addasync(T entidad)
        {
            try
            {
                await _dbset.AddAsync(entidad); //insertar todas las tablas
                await _DBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            { 
              throw new Exception("Error: No se pudo insertar datos," + ex.Message, ex);
            }

        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entidad = await GetByIdAsync(id);
                _dbset.Remove(entidad); //eliminar todas las tablas
                await _DBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar datos," + ex.Message, ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {

                return await _dbset.ToListAsync(); //Listar todas las tablas
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar datos," + ex.Message, ex);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {

                return await _dbset.FindAsync(); //Buscar todas las tablas por id -- siempre que sean números
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar datos," + ex.Message, ex);
            }
        }

        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbset.Update(entidad); //actualizar todas las tablas
                await _DBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar datos," + ex.Message, ex);
            }
        }
    }
}
