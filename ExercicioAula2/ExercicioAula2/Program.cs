public class ExercicioAula2
{
    public static void Main()
    {
        
    }
    
    public static void simulacaoQuedaLivre()
    {
        //Posição inicial(altura), tempo

    }

    public static void movimentoProjetil()
    {
        //Velocidade, ângulo, tempo, altura, masssa

        Console.WriteLine("Velocidade do projétil(km/h): ");
        var velocidade = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ângulo do disparo(graus): ");
        var angulo = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Altura do disparo(m): ");
        var altura = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Tempo após disparo(s): ");
        var tempo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Massa do projétil: ");
        var masssa = Convert.ToInt32(Console.ReadLine());

        if (angulo > 180 || angulo < 0)
        {
            throw new Exception("Ângulo não permitido.");        
        }

        if (angulo > 10 || angulo < 170) 
        {
            //Vertical
            
            var aceleracaoGravitacional = 
            
            var posicao = velocidade + 

        }
        else
        {
            //Horizontal
        }
    }

    public static void colisaoParticulas()
    {
        //Massa e velocidade
    }

    public static void penduloSimples()
    {

    }

    public static void movimentoCircularUniforme()
    {

    }


}


