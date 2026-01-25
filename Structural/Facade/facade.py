class Facade:
    def __init__(self):
        self._subsystem1 = Subsystem1()
        self._subsystem2 = Subsystem2()

    def operation(self) -> str:
        results = []
        results.append("Facade initializes subsystems:")
        results.append(self._subsystem1.operation_1())
        results.append(self._subsystem2.operation_1())
        return "\n".join(results)

class Subsystem1:
    def operation_1(self) -> str: return "Subsystem1: Ready!"

class Subsystem2:
    def operation_1(self) -> str: return "Subsystem2: Go!"