from abc import ABC, abstractmethod
from typing import List

class Component(ABC):
    def __init__(self, name: str):
        self.name = name

    @abstractmethod
    def operation(self) -> None:
        pass

    def add(self, component: 'Component') -> None:
        raise NotImplementedError

    def remove(self, component: 'Component') -> None:
        raise NotImplementedError

    def get_child(self, index: int) -> 'Component':
        raise NotImplementedError

class Leaf(Component):
    def operation(self) -> None:
        print(f"Leaf {self.name} operation")

class Composite(Component):
    def __init__(self, name: str):
        super().__init__(name)
        self.children: List[Component] = []

    def operation(self) -> None:
        print(f"Composite {self.name} operation")
        for child in self.children:
            child.operation()

    def add(self, component: Component) -> None:
        self.children.append(component)

    def remove(self, component: Component) -> None:
        self.children.remove(component)

    def get_child(self, index: int) -> Component:
        return self.children[index]