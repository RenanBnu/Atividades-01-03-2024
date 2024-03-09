
using ExercicioAula2;
using ExercicioAula2.Model;
using NUnit.Framework.Internal.Execution;

namespace TestesSimulacao
{
    public class TestesSimulacao
    {
        public static void Main()
        {
            simulacaoQuedaLivreTeste();
            movimentoProjetilTeste();
            penduloSimplesTeste();
        }

        public static void simulacaoQuedaLivreTeste()
        {
            SimulacaoQuedaLivre.AlturaInicial = 10;
            SimulacaoQuedaLivre.Tempo = 10;

            AlgoritmosSimulacao.simulacaoQuedaLivre();

            if (SimulacaoQuedaLivre.Posicao == 500.5M && SimulacaoQuedaLivre.Velocidade == 98.10000000000001)
            {
                Console.WriteLine("Simulação de queda livre: sucesso");
            }
            else
            {
                Console.WriteLine("Simulação de queda livre: erro");
            }
        }

        public static void movimentoProjetilTeste()
        {
            MovimentoProjetil.Velocidade = 10;
            MovimentoProjetil.Angulo = 30;
            MovimentoProjetil.Altura = 10;
            MovimentoProjetil.Tempo = 10;

            AlgoritmosSimulacao.movimentoProjetil();

            if (MovimentoProjetil.PosicaoHorizontal == 86.602540378443900M && MovimentoProjetil.PosicaoVertical == -430.0M)
            {
                Console.WriteLine("Movimento projétil: sucesso");
            }
            else
            {
                Console.WriteLine("Movimento projétil: erro");
            }
        }

        public static void penduloSimplesTeste()
        {
            PenduloSimples.AmplitudeInicial = 90;
            PenduloSimples.IntervaloTempo = 1;

            AlgoritmosSimulacao.penduloSimples();

            if (PenduloSimples.Tempo == 2 && PenduloSimples.PosicaoAngular == 1.5704094424249706)
            {
                Console.WriteLine("Pendulo simples: sucesso");
            }
            else
            {
                Console.WriteLine("Pendulo simples: erro");
            }
        }
    }
}