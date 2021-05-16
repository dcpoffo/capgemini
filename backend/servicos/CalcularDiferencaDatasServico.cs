using System;

namespace backend.servicos
{
    public class CalcularDiferencaDatasServico
    {
        public int quantidadeDias = 0;
        
        public int CalculaDiferencaDatas(DateTime dataF, DateTime dataI){
            quantidadeDias = (int)dataF.Subtract(dataI).TotalDays;
            return quantidadeDias;
        }
    }
}