using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Model
{
    public static class MovimentoProjetil
    {
        public static decimal Velocidade {  get; set; }
        public static int? Angulo { get; set; } = null;
        public static int? Altura { get; set; }
        public static int Tempo { get; set; }
        public static double AnguloRadianos {  get; set; }
        public static decimal VelocidadeInicialX { get; set; }
        public static decimal VelocidadeInicialY { get; set; }
        public static decimal PosicaoHorizontal { get; set; }
        public static decimal PosicaoVertical { get; set; }
    }
}
