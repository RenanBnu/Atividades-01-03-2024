using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula2.Model
{
    public static class PenduloSimples
    {
        public static double TamanhoCorda { get; } = 1.0;
        public static double AceleracaoGravitacional { get; } = 9.8; // em m/s^2
        public static double AmplitudeInicial { get; set; }
        public static double IntervaloTempo { get; set; }
        public static double AmplitudeRadianos { get; set; }
        public static double Periodo { get; set; }
        public static double Tempo { get; set; }
        public static double PosicaoAngular { get; set; }
    }
}
