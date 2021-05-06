using System.Linq;
using System.Threading.Tasks;
using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.data
{
     public class Repository : IRepository
     {
          private readonly DataContext _context;

          public Repository(DataContext context)
          {
               this._context = context;
          }

          public void Add<T>(T entity) where T : class
          {
               _context.Add(entity);
          }

          public void Delete<T>(T entity) where T : class
          {
               _context.Remove(entity);               
          }

          public void Update<T>(T entity) where T : class
          {
               _context.Update(entity);
          }

          public async Task<bool> SaveChangesAsync()
          {
               return (await _context.SaveChangesAsync()) > 0;
          }          

          public async Task<Cliente[]> GetAllClientesAsync()
          {
               IQueryable<Cliente> query = _context.Cliente;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }         

          public async Task<Cliente> GetClienteAsyncById(int pessosId)
          {
               IQueryable<Cliente> query = _context.Cliente;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == pessosId);

               return await query.FirstOrDefaultAsync();
          }

          public async Task<Anuncio[]> GetAllAnunciosAsync()
          {
               IQueryable<Anuncio> query = _context.Anuncio;
               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }

          public async Task<Anuncio> GetAnuncioAsyncById(int anuncioId)
          {
               IQueryable<Anuncio> query = _context.Anuncio;
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == anuncioId);

               return await query.FirstOrDefaultAsync();
          }
     }
}