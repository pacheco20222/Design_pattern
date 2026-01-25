class AbstractFactory(ABC):
    @abstractmethod
    def create_product_a(self): pass
    @abstractmethod
    def create_product_b(self): pass

class ConcreteFactory1(AbstractFactory):
    def create_product_a(self): return ProductA1()
    def create_product_b(self): return ProductB1()

class ProductA1:
    def useful_function_a(self): return "Product A1 result."

class ProductB1:
    def useful_function_b(self): return "Product B1 result."