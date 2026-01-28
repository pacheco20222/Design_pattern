import math

# Interfaz del Visitor
class Visitor:
    def visit_circulo(self, circulo):
        pass

    def visit_cuadrado(self, cuadrado):
        pass

# Clases de elementos
class Figura:
    def accept(self, visitor: Visitor):
        pass

class Circulo(Figura):
    def __init__(self, radio=5):
        self.radio = radio

    def accept(self, visitor: Visitor):
        visitor.visit_circulo(self)

class Cuadrado(Figura):
    def __init__(self, lado=3):
        self.lado = lado

    def accept(self, visitor: Visitor):
        visitor.visit_cuadrado(self)

# Visitor concreto
class CalculadoraAreas(Visitor):
    def visit_circulo(self, circulo: Circulo):
        area = math.pi * circulo.radio ** 2
        print(f"Área del círculo: {area}")

    def visit_cuadrado(self, cuadrado: Cuadrado):
        area = cuadrado.lado ** 2
        print(f"Área del cuadrado: {area}")

# Uso
figuras = [Circulo(), Cuadrado()]
calculadora = CalculadoraAreas()

for figura in figuras:
    figura.accept(calculadora)
