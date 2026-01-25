class Subject(ABC):
    @abstractmethod
    def attach(self, observer): pass
    @abstractmethod
    def notify(self): pass

class ConcreteSubject(Subject):
    _observers = []
    def attach(self, observer): self._observers.append(observer)
    def notify(self):
        for observer in self._observers:
            observer.update(self)