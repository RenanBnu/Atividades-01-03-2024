class Particula:
    def __init__(self, massa, velocidade):
        self.massa = massa
        self.velocidade = velocidade


def colisao_elastica(particula1, particula2):
     # Calcular velocidade final da primeira partícula
    vf1 = ((particula1.massa - particula2.massa) * particula1.velocidade[0] + 2 * particula2.massa *
           particula2.velocidade[0]) / (particula1.massa + particula2.massa)
    vf2 = ((particula2.massa - particula1.massa) * particula2.velocidade[0] + 2 * particula1.massa *
           particula1.velocidade[0]) / (particula1.massa + particula2.massa)

    # Atualizar as velocidades finais das partículas
    particula1.velocidade[0] = vf1
    particula2.velocidade[0] = vf2


def main():
    # Entrada do usuário para massas e velocidades iniciais das partículas
    m1 = float(input("Digite a massa da primeira partícula (em kg): "))
    m2 = float(input("Digite a massa da segunda partícula (em kg): "))
    v1_x = float(input("Digite a velocidade inicial x da primeira partícula (em m/s): "))
    v1_y = float(input("Digite a velocidade inicial y da primeira partícula (em m/s): "))
    v2_x = float(input("Digite a velocidade inicial x da segunda partícula (em m/s): "))
    v2_y = float(input("Digite a velocidade inicial y da segunda partícula (em m/s): "))

    # Criar objetos Particula para cada partícula
    particula1 = Particula(m1, [v1_x, v1_y])
    particula2 = Particula(m2, [v2_x, v2_y])

    # Calcular velocidades finais após a colisão
    colisao_elastica(particula1, particula2)

    # Imprimir velocidades finais das partículas
    print("\nVelocidades finais das partículas após a colisão:")
    print("Partícula 1: ({:.2f}, {:.2f}) m/s".format(particula1.velocidade[0], particula1.velocidade[1]))
    print("Partícula 2: ({:.2f}, {:.2f}) m/s".format(particula2.velocidade[0], particula2.velocidade[1]))


if __name__ == "__main__":
    main()
