class Adaptee:
    def specific_request(self) -> str:
        return "Specific request."

class Target:
    def request(self) -> str:
        return "Target: The default target's behavior."

class Adapter(Target):
    def __init__(self, adaptee: Adaptee):
        self.adaptee = adaptee
    def request(self) -> str:
        return f"Adapter: (TRANSLATED) {self.adaptee.specific_request()}"