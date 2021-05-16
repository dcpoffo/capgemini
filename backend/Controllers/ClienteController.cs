using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class ClienteController : ControllerBase
     {
          private readonly IRepository _repositorio;

          public ClienteController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllClientesAsync(true);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Clientes: \n{ex.Message}");
               }
          }

          [HttpGet("{clienteId}")]
          public async Task<IActionResult> GetById(int clienteId)
          {
               try
               {
                    var result = await _repositorio.GetClienteAsyncById(clienteId, true);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Cliente: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(Cliente cliente)
          {
               try
               {
                    _repositorio.Add(cliente);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(cliente);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Cliente: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{clienteId}")]
          public async Task<IActionResult> Put(int clienteId, Cliente cliente)
          {
               try
               {
                    var cadastro = await _repositorio.GetClienteAsyncById(clienteId, false);

                    if (cadastro == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(cliente);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(cliente);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Cliente: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{clienteId}")]
          public async Task<IActionResult> Delete(int clienteId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetClienteAsyncById(clienteId, false);
                    if (cadastrado == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Delete(cadastrado);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(
                              new
                              {
                                   message = "Cliente removido com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Cliente: {ex.Message}");
               }
               return BadRequest();
          }
     }
}