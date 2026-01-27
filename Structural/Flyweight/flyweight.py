from abc import ABC, abstractmethod
from typing import Dict

class Flyweight(ABC):
    @abstractmethod
    def operation(self, extrinsic_state: str) -> None:
        pass

class ConcreteFlyweight(Flyweight):
    def __init__(self, intrinsic_state: str):
        self.intrinsic_state = intrinsic_state

    def operation(self, extrinsic_state: str) -> None:
        print(f"ConcreteFlyweight: {self.intrinsic_state}, {extrinsic_state}")

class FlyweightFactory:
    def __init__(self):
        self.flyweights: Dict[str, Flyweight] = {}

    def get_flyweight(self, key: str) -> Flyweight:
        if key not in self.flyweights:
            self.flyweights[key] = ConcreteFlyweight(key)
        return self.flyweights[key]