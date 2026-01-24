class Builder(ABC):
    @abstractmethod
    def build_part_a(self): pass
    @abstractmethod
    def build_part_b(self): pass

class Product():
    def __init__(self):
        self.parts = []
    def add(self, part):
        self.parts.append(part)

class ConcreteBuilder(Builder):
    def __init__(self):
        self.reset()
    def reset(self):
        self._product = Product()
    def build_part_a(self):
        self._product.add("PartA1")
    def build_part_b(self):
        self._product.add("PartB1")
    def get_product(self):
        return self._product