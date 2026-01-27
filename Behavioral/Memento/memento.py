class Memento:
    def __init__(self, state):
        self.state = state

class Editor:
    def __init__(self):
        self.text = ""

    def save(self):
        return Memento(self.text)

    def restore(self, memento):
        self.text = memento.state
