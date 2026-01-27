from abc import ABC, abstractmethod

class Implementor(ABC):
    @abstractmethod
    def operation_impl(self) -> None:
        pass

class ConcreteImplementorA(Implementor):
    def operation_impl(self) -> None:
        print("ConcreteImplementorA Operation")

class ConcreteImplementorB(Implementor):
    def operation_impl(self) -> None:
        print("ConcreteImplementorB Operation")

class Abstraction(ABC):
    def __init__(self, implementor: Implementor):
        self.implementor = implementor

    @abstractmethod
    def operation(self) -> None:
        pass

class RefinedAbstraction(Abstraction):
    def operation(self) -> None:
        print("RefinedAbstraction: ", end="")
        self.implementor.operation_impl()