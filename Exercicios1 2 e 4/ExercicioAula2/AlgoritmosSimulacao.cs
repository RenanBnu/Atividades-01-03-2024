
using ExercicioAula2.Model;
using System;

namespace ExercicioAula2
{
    public class AlgoritmosSimulacao
    {
        public static void Main()
        {
            Console.WriteLine("Selecione a simulação desejada(1 - Queda livre, 2 - Movimento projétil, 3 - Pendulo simples):");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    simulacaoQuedaLivre();
                    break;
                case "2":
                    movimentoProjetil();
                    break;
                case "3":
                    penduloSimples();
                    break;
                default:
                    break;
            }
        }

        public static void simulacaoQuedaLivre()
        {
            //Posição inicial(altura), tempo

            if (SimulacaoQuedaLivre.AlturaInicial == 0)
            {
                Console.WriteLine("Altura inicial do objeto em metros:");
                SimulacaoQuedaLivre.AlturaInicial = Convert.ToDecimal(Console.ReadLine());
            }

            if (SimulacaoQuedaLivre.Tempo == 0)
            {
                Console.WriteLine("Digite o tempo desejado (em segundos):");
                SimulacaoQuedaLivre.Tempo = Convert.ToDouble(Console.ReadLine());
            }

            if (SimulacaoQuedaLivre.AlturaInicial != 0 && SimulacaoQuedaLivre.Tempo != 0)
            {
                // Calculando a velocidade usando a fórmula: v = gt
                SimulacaoQuedaLivre.Velocidade = SimulacaoQuedaLivre.Gravidade * SimulacaoQuedaLivre.Tempo;

                // Calculando a posição usando a fórmula: s = ut + (1/2)gt^2
                SimulacaoQuedaLivre.Posicao = SimulacaoQuedaLivre.AlturaInicial + Convert.ToDecimal(0.5 * SimulacaoQuedaLivre.Gravidade * Math.Pow(SimulacaoQuedaLivre.Tempo, 2));

                // Exibindo a posição e velocidade no tempo especificado pelo usuário
                Console.WriteLine($"Tempo: {SimulacaoQuedaLivre.Tempo} s: Posição: {SimulacaoQuedaLivre.Posicao} m - Velocidade: {SimulacaoQuedaLivre.Velocidade} m/s");
            }
        }

        public static void movimentoProjetil()
        {
            //Velocidade, ângulo, tempo, altura(desconsiderando resistência do ar)
            if (MovimentoProjetil.Velocidade == 0)
            {
                Console.WriteLine("Velocidade do projétil(m/s): ");
                MovimentoProjetil.Velocidade = Convert.ToDecimal(Console.ReadLine());
            }

            if (MovimentoProjetil.Angulo == null)
            {
                Console.WriteLine("Ângulo do disparo(graus): ");
                MovimentoProjetil.Angulo = Convert.ToInt16(Console.ReadLine());
            }   

            if (MovimentoProjetil.Altura == null)
            {
                Console.WriteLine("Altura do disparo(m): ");
                MovimentoProjetil.Altura = Convert.ToInt16(Console.ReadLine());
            }

            if (MovimentoProjetil.Tempo == 0)
            {
                Console.WriteLine("Tempo após disparo(s): ");
                MovimentoProjetil.Tempo = Convert.ToInt32(Console.ReadLine());
            }

            if (MovimentoProjetil.Velocidade != 0 && MovimentoProjetil.Angulo != null && MovimentoProjetil.Altura != null && MovimentoProjetil.Tempo != 0)
            {
                // Converte o ângulo para radianos
                MovimentoProjetil.AnguloRadianos = Convert.ToDouble(MovimentoProjetil.Angulo) * Math.PI / 180;

                // Cálculos de velocidade inicial
                MovimentoProjetil.VelocidadeInicialX = MovimentoProjetil.Velocidade * Convert.ToDecimal(Math.Cos(MovimentoProjetil.AnguloRadianos));
                MovimentoProjetil.VelocidadeInicialY = MovimentoProjetil.Velocidade * Convert.ToDecimal(Math.Sin(MovimentoProjetil.AnguloRadianos));

                // Cálculo de posição horizontal
                MovimentoProjetil.PosicaoHorizontal = MovimentoProjetil.VelocidadeInicialX * MovimentoProjetil.Tempo;

                // Cálculo de posição vertical
                MovimentoProjetil.PosicaoVertical = Convert.ToDecimal(MovimentoProjetil.Altura) + MovimentoProjetil.VelocidadeInicialY * MovimentoProjetil.Tempo - Convert.ToDecimal((0.5 * 9.8 * MovimentoProjetil.Tempo * MovimentoProjetil.Tempo));

                Console.WriteLine($"A posição horizontal do projétil após {MovimentoProjetil.Tempo} segundos é {MovimentoProjetil.PosicaoHorizontal} metros.");
                Console.WriteLine($"A posição vertical do projétil após {MovimentoProjetil.Tempo} segundos é {MovimentoProjetil.PosicaoVertical} metros.");
            }
        }

        public static void penduloSimples()
        {
            if (PenduloSimples.AmplitudeInicial == 0)
            {
                Console.WriteLine("Amplitude inicial do pêndulo (em graus):");
                PenduloSimples.AmplitudeInicial = double.Parse(Console.ReadLine());
            }

            if (PenduloSimples.IntervaloTempo == 0)
            {
                Console.WriteLine("Intervalo de tempo entre os cálculos (em segundos):");
                PenduloSimples.IntervaloTempo = double.Parse(Console.ReadLine());
            }

            if (PenduloSimples.AmplitudeInicial != 0 && PenduloSimples.IntervaloTempo != 0)
            {
                // Convertendo a amplitude inicial de graus para radianos
                PenduloSimples.AmplitudeRadianos = PenduloSimples.AmplitudeInicial * Math.PI / 180;

                // Calculando o período do pêndulo simples
                PenduloSimples.Periodo = 2 * Math.PI * Math.Sqrt(PenduloSimples.TamanhoCorda / PenduloSimples.AceleracaoGravitacional);

                // Inicializando o tempo
                PenduloSimples.Tempo = 0;

                // Simulação do movimento do pêndulo
                while (true)
                {
                    // Calculando a posição angular do pêndulo no tempo atual
                    PenduloSimples.PosicaoAngular = PenduloSimples.AmplitudeRadianos * Math.Cos(2 * Math.PI * PenduloSimples.Tempo / PenduloSimples.Periodo);

                    // Exibindo a posição angular
                    Console.WriteLine($"Tempo: {PenduloSimples.Tempo} s, Posição Angular: {PenduloSimples.PosicaoAngular} rad");

                    // Atualizando o tempo
                    PenduloSimples.Tempo += PenduloSimples.IntervaloTempo;

                    // Verificando se o tempo ultrapassou um período completo
                    if (PenduloSimples.Tempo > PenduloSimples.Periodo)
                    {
                        PenduloSimples.Tempo -= PenduloSimples.IntervaloTempo;
                        break;
                    }
                }
            }
        }
    }
}


