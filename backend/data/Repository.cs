using System;
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

          public async Task<Cliente[]> GetAllClientesAsync(bool incluirAnuncio)
          {
               IQueryable<Cliente> query = _context.Cliente;

               if (incluirAnuncio)
               {
                   query = query.Include(anu => anu.Anuncios);
               }

               query = query.AsNoTracking().OrderBy(a => a.Id);

               return await query.ToArrayAsync();
          }         

          public async Task<Cliente> GetClienteAsyncById(int pessosId, bool incluirAnuncio)
          {
               IQueryable<Cliente> query = _context.Cliente;
               
               if (incluirAnuncio)
               {
                    query = query.Include(a => a.Anuncios);
               }
               
               query = query.AsNoTracking().OrderBy(a => a.Id)
                                           .Where(a => a.Id == pessosId);

               return await query.FirstOrDefaultAsync();
          }
       
          public async Task<Anuncio[]> GetAllAnunciosAsync(bool incluirCliente)
          {
               IQueryable<Anuncio> query = _context.Anuncio;

               if (incluirCliente)
               {
                   query = query.Include(cli => cli.Cliente);
               }

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

          public async Task<Anuncio[]> GetAllAnunciosByClienteAsync(bool incluirCliente, string nomeCliente)
          {
               IQueryable<Anuncio> query = _context.Anuncio;

               if (incluirCliente)
               {
                   query = query.Include(cli => cli.Cliente);                                   
               }
               
               query = query.AsNoTracking()
                    .OrderBy(a => a.Id)               
                    .Where(a => a.Cliente.Nome.Contains(nomeCliente));

               return await query.ToArrayAsync();
          }

          public async Task<Anuncio[]> GetAllAnunciosByDataAsync(bool incluirCliente, DateTime dataI, DateTime dataF)
          {
               IQueryable<Anuncio> query = _context.Anuncio;

               if (incluirCliente)
               {
                   query = query.Include(cli => cli.Cliente);                                   
               }
              
               query = query.AsNoTracking()
                    .OrderBy(a => a.Id)               
                    .Where(a => a.DataInicio >= dataI && a.DataTermino <= dataF);

               return await query.ToArrayAsync();
          }

          public async Task<Anuncio[]> GetAllAnunciosPesquisaAsync(bool incluirCliente, string nomeCliente, DateTime dataI, DateTime dataF)
          {
               IQueryable<Anuncio> query = _context.Anuncio;

               if (incluirCliente)
               {
                   query = query.Include(cli => cli.Cliente);                              
               }

               query = query.AsNoTracking()
                    .OrderBy(a => a.Id)               
                    .Where((a => a.Cliente.Nome.Contains(nomeCliente) && (a.DataInicio >= dataI && a.DataTermino <= dataF)));

               return await query.ToArrayAsync();
          }
     }
}