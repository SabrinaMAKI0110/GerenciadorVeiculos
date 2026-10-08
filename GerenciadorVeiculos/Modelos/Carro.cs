using System;

namespace GerenciadorVeiculos.Modelos
{

    // Os dois pontos (:) indicam que Carro herda de Veiculo
    public class Carro : Veiculo
    {
        // Informação exclusiva de carros 
        public int Portas { get; set; }
        
        // O construtor repassa modelo e diária para a classe mãe através do base()
        public Carro(string modelo, decimal valorDiaria, int portas) : base(modelo, valorDiaria)
        {
            Portas = portas;
        }

        //override = para substituir aquele método da classe mãe
        //Polimorfismo: para Carro, o seguro é de 10% do valor da diaria
        public override decimal CalcularSeguro()
        {
            return ValorDiaria * 0.10m;
        }
    }
}
