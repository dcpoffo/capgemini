using System;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using backend.servicos;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AnuncioController : ControllerBase
    {
        private readonly IRepository _repositorio;

          public AnuncioController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllAnunciosAsync(true);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Anuncios: \n{ex.Message}");
               }
          }

          [HttpGet("{anuncioId}")]
          public async Task<IActionResult> GetById(int anuncioId)
          {
               try
               {
                    var result = await _repositorio.GetAnuncioAsyncById(anuncioId);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Anuncio: \n{ex.Message}");
               }
          }

          [HttpPost]
          public async Task<IActionResult> Post(Anuncio anuncio)
          {
               CalcularDiferencaDatasServico calcular = new CalcularDiferencaDatasServico();
               anuncio.QuantidadeDias = calcular.CalculaDiferencaDatas(anuncio.DataTermino,anuncio.DataInicio);

               try
               {
                    _repositorio.Add(anuncio);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(anuncio);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Anuncio: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpPut("{anuncioId}")]
          public async Task<IActionResult> Put(int anuncioId, Anuncio anuncio)
          {
               try
               {
                    var cadastrado = await _repositorio.GetAnuncioAsyncById(anuncioId);

                    if (cadastrado == null)
                    {
                         return NotFound();
                    }

                    CalcularDiferencaDatasServico calcular = new CalcularDiferencaDatasServico();
                    anuncio.QuantidadeDias = calcular.CalculaDiferencaDatas(anuncio.DataTermino,anuncio.DataInicio);

                    _repositorio.Update(anuncio);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(anuncio);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao alterar Anuncio: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpDelete("{anuncioId}")]
          public async Task<IActionResult> Delete(int anuncioId)
          {
               try
               {
                    var cadastrado = await _repositorio.GetAnuncioAsyncById(anuncioId);
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
                                   message = "Anuncio removido com sucesso"
                              }
                         );
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao excluir a Assunto: {ex.Message}");
               }
               return BadRequest();
          }

          [HttpGet("nome={nomeCliente}/di={dataI}/df={dataF}")]
          public async Task<IActionResult> GetAllAnunciosByPesquisa(string nomeCliente, DateTime dataI, DateTime dataF)
          {
               try
               {
                    var result = await _repositorio.GetAllAnunciosPesquisaAsync(true, nomeCliente, dataI, dataF);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Anuncios: \n{ex.Message}");
               }
          }

          [HttpGet("di={dataI}/df={dataF}")]
          public async Task<IActionResult> GetAllAnuncioByData(DateTime dataI, DateTime dataF)
          {
               try
               {
                    var result = await _repositorio.GetAllAnunciosByDataAsync(true,dataI,dataF);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Anuncios: \n{ex.Message}");
               }
          }

          [HttpGet("nome={nomeCliente}")]
          public async Task<IActionResult> GetAllAnuncioByNome(string nomeCliente)
          {
               try
               {
                    var result = await _repositorio.GetAllAnunciosByClienteAsync(true,nomeCliente);
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Anuncios: \n{ex.Message}");
               }
          }
    }
}