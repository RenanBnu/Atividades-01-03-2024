using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Model
{
    public static class SimulacaoQuedaLivre
    {
        public static decimal AlturaInicial {  get; set; }
        public static double Tempo { get; set; }
        public static double Gravidade { get; } = 9.81;
        public static double Velocidade { get; set; }
        public static decimal Posicao { get; set; }
    }
}
