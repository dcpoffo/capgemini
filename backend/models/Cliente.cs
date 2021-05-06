using System.Collections;
using System.Collections.Generic;

namespace backend.models
{
     public class Cliente
     {
          public Cliente(int id, string nome)
          {
               this.Id = id;
               this.Nome = nome;               
          }
          public int Id { get; set; }
          public string Nome { get; set; }

          public IEnumerable<Anuncio> Anuncios { get; set; }

          public Cliente()
          { }
     }
}