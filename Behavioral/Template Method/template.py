from abc import ABC, abstractmethod

class Game(ABC):
    def play(self):
        self.start()
        self.end()

    @abstractmethod
    def start(self): pass

    @abstractmethod
    def end(self): pass

class Soccer(Game):
    def start(self): pass
    def end(self): pass
