class Singleton:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super().__new__(cls)
        return cls._instance

    def show_message(self):
        print("Hola desde el Singleton en Python!")

# Ejemplo de uso
if __name__ == "__main__":
    s1 = Singleton()
    s2 = Singleton()

    print(s1 is s2)  # True, misma instancia

    s1.show_message()