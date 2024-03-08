import math


def calcular_movimento_circular_uniforme(raio, velocidade_angular):
    # Calcular velocidade tangencial
    velocidade_tangencial = raio * velocidade_angular

    # Calcular aceleração centrípeta
    aceleracao_centripeta = velocidade_angular ** 2 * raio

    return velocidade_angular, velocidade_tangencial, aceleracao_centripeta


def main():
    # Solicitar entrada do usuário para raio e velocidade angular
    raio = float(input("Digite o raio da trajetória circular (em metros): "))
    velocidade_angular = float(input("Digite a velocidade angular (em rad/s): "))

    # Calcular outras quantidades físicas
    velocidade_angular, velocidade_tangencial, aceleracao_centripeta = calcular_movimento_circular_uniforme(raio,
                                                                                                            velocidade_angular)

    # Imprimir resultados
    print("\nResultados:")
    print("Velocidade angular (rad/s):", velocidade_angular)
    print("Velocidade tangencial (m/s):", velocidade_tangencial)
    print("Aceleração centrípeta (m/s^2):", aceleracao_centripeta)


if __name__ == "__main__":
    main()
