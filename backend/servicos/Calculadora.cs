using System;

namespace backend.servicos
{
     public class Calculadora
    {
        public double quantidadeAlcance = 0;
        public double quantidadeCliques = 0;
        public double quantidadeCompartilhamentos = 0;
        public double quantidadeNovosCompartilhamentos = 0;
        public int maximoCompartilhamentos = 0;
        public int CalculaMaximoCompartilhamento(double valor)
        {
            quantidadeAlcance = valor * 30;
            quantidadeCliques = quantidadeAlcance * 0.12;
            quantidadeCompartilhamentos = quantidadeCliques * 0.3;
            quantidadeNovosCompartilhamentos = quantidadeCompartilhamentos * 40;
            maximoCompartilhamentos = Convert.ToInt32(quantidadeNovosCompartilhamentos + 160);
            return maximoCompartilhamentos;
        }
    }
}