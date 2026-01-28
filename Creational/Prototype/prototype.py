import copy

class Prototype:
    def __init__(self, value):
        self.value = value

    def clone(self):
        return copy.deepcopy(self)

    def show_info(self):
        print(f"Valor: {self.value}")

# Ejemplo de uso
if __name__ == "__main__":
    original = Prototype("Original")
    clone = original.clone()

    print("Original:")
    original.show_info()

    print("Clon:")
    clone.show_info()

    # Modificar el clon
    clone.value = "Modificado"
    print("Después de modificar el clon:")
    original.show_info()
    clone.show_info()