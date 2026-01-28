class State:
    def handle(self, context):
        pass

class Context:
    def __init__(self, state):
        self.state = state

    def request(self):
        self.state.handle(self)

class OnState(State):
    def handle(self, context):
        context.state = OffState()

class OffState(State):
    def handle(self, context):
        context.state = OnState()
