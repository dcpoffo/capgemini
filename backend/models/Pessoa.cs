using System.Collections.Generic;

namespace backend.models
{
     public class Pessoa
     {         
          public int Id { get; set; }
          public string Nome { get; set; }
          public string Sobrenome { get; set; }

          public Pessoa()
          { }

          public Pessoa(int id, string nome, string sobrenome)
          {
               this.Id = id;
               this.Nome = nome;
               this.Sobrenome = sobrenome;
          }          
     }
}