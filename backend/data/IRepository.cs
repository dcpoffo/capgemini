using System;
using System.Threading.Tasks;
using backend.models;

namespace backend.data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T> (T entity) where T : class;
        Task<bool> SaveChangesAsync();
        
        Task<Cliente[]> GetAllClientesAsync(bool incluirAnuncio);
        Task<Cliente> GetClienteAsyncById(int clienteId, bool incluirAnuncio);   
        Task<Anuncio[]> GetAllAnunciosAsync(bool incluirCliente);

        Task<Anuncio[]> GetAllAnunciosByClienteAsync(bool incluirCliente, string nomeCliente);
        Task<Anuncio[]> GetAllAnunciosByDataAsync(bool incluirCliente, DateTime dataI, DateTime dataF);
        Task<Anuncio[]> GetAllAnunciosPesquisaAsync(bool incluirCliente, string nomeCliente, DateTime dataI, DateTime dataF);
        
        Task<Anuncio> GetAnuncioAsyncById(int anuncioId);  


    }
}