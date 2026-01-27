# Mediator Pattern in Python

class Mediator:
    def send(self, message, colleague):
        pass

class Colleague:
    def __init__(self, mediator):
        self.mediator = mediator

class User(Colleague):
    def __init__(self, name, mediator):
        super().__init__(mediator)
        self.name = name

    def send(self, message):
        print(f"{self.name} sends: {message}")
        self.mediator.send(message, self)

    def receive(self, message):
        print(f"{self.name} receives: {message}")

class ChatRoom(Mediator):
    def __init__(self):
        self.users = []

    def add_user(self, user):
        self.users.append(user)

    def send(self, message, user):
        for u in self.users:
            if u != user:
                u.receive(message)

# Usage
chat_room = ChatRoom()
user1 = User("Alice", chat_room)
user2 = User("Bob", chat_room)
chat_room.add_user(user1)
chat_room.add_user(user2)

user1.send("Hello, Bob!")  # Alice sends: Hello, Bob!
                          # Bob receives: Hello, Bob!