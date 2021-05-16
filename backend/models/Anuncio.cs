using System;

namespace backend.models
{
     public class Anuncio
     {
          public Anuncio(int id, double investimentoDiario, int clienteId, DateTime dataInicio, DateTime dataTermino, int quantidadeDias, string nome)
          {
               this.Id = id;
               this.Nome = nome;
               this.ClienteId = clienteId;
               this.DataInicio = dataInicio;
               this.DataTermino = dataTermino;
               this.QuantidadeDias = quantidadeDias;
               this.InvestimentoDiario = investimentoDiario;
          }
          public int Id { get; set; }
          public string Nome { get; set; }
          public int ClienteId { get; set; }
          public DateTime DataInicio { get; set; }
          public DateTime DataTermino { get; set; }
          public int QuantidadeDias { get; set; }
          public double InvestimentoDiario { get; set; }
          public Cliente Cliente { get; set; }

          public Anuncio()
          { }

     }
}