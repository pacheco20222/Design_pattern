class Strategy(ABC):
    @abstractmethod
    def do_algorithm(self, data): pass

class Context:
    def __init__(self, strategy: Strategy):
        self._strategy = strategy
    def set_strategy(self, strategy: Strategy):
        self._strategy = strategy
    def do_something(self):
        result = self._strategy.do_algorithm(["a", "b"])
        print(result)