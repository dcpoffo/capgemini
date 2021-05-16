using System;

namespace backend.models
{
     public class Anuncio
     {

          public Anuncio(int id, string nome, int clienteId, DateTime dataInicio, DateTime dataTermino, double investimentoDiario)
          {
               this.Id = id;
               this.Nome = nome;
               this.ClienteId = clienteId;
               this.DataInicio = dataInicio;
               this.DataTermino = dataTermino;
               this.InvestimentoDiario = investimentoDiario; 
          }
          public int Id { get; set; }
          public string Nome { get; set; }
          public int ClienteId { get; set; }
          public DateTime DataInicio { get; set; }
          public DateTime DataTermino { get; set; }
          public double InvestimentoDiario { get; set; }
          public Cliente Cliente { get; set; }

          public Anuncio()
          { }

     }
}