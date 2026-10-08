using System;

namespace GerenciadorVeiculos.Modelos
{

    // ↓ A Classe Veículo é abstrata porque ela serve de molde para Carro e Moto

    public abstract class Veiculo
    {
        // Propriedades: guardam as informações do veículo
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal ValorDiaria { get; set; }

        // Método Construtor: usado para preencher os dados ao criar o veículo na memória
        // protected = serve para que o Veiculo não seja acessado por ninguém mais

        // o modelo e valordiaria com letra minúscula são parâmetros do construtor, não propriedades da classe, que vão ser salvas nas variáveis
        protected Veiculo(string modelo, decimal valorDiaria) 
        {
            Modelo = modelo;
            ValorDiaria = valorDiaria;
        }

        // Método Abstrato: toda classe filha é obrigada a ter este cálculo
        public abstract decimal CalcularSeguro();

    }
}
