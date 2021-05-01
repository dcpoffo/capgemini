using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class PessoaController : ControllerBase
     {
          private readonly IRepository _repositorio;

          public PessoaController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllPessoasAsync();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Pessoas: \n{ex.Message}");
               }
          }

          [HttpGet("{pessoaId}")]
          public async Task<IActionResult> GetById(int pessoaId)
          {
               try
               {
                    var result = await _repositorio.GetPessoaAsyncById(pessoaId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Pessoa: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(Pessoa pessoa)
          {
               try
               {
                    _repositorio.Add(pessoa);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(pessoa);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Pessoa: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{pessoaId}")]
          public async Task<IActionResult> Put(int pessoaId, Pessoa pessoa)
          {
               try
               {
                    var pessoaCadastrada = await _repositorio.GetPessoaAsyncById(pessoaId);

                    if (pessoaCadastrada == null)
                    {
                         return NotFound();
                    }

                    _repositorio.Update(pessoa);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(pessoa);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Pessoa: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{pessoaId}")]
          public async Task<IActionResult> Delete(int pessoaId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetPessoaAsyncById(pessoaId);
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
                                   message = "Pessoa removida com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Pessoa: {ex.Message}");
               }
               return BadRequest();
          }
     }
}