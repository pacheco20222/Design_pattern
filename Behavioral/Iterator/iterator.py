# Iterator
class NameIterator:
    def __init__(self, names):
        self._names = names
        self._index = 0

    def has_next(self):
        return self._index < len(self._names)

    def next(self):
        value = self._names[self._index]
        self._index += 1
        return value


# Aggregate
class NameCollection:
    def __init__(self):
        self._names = ["Ana", "Luis", "María"]

    def create_iterator(self):
        return NameIterator(self._names)


# Client
collection = NameCollection()
iterator = collection.create_iterator()

while iterator.has_next():
    print(iterator.next())
