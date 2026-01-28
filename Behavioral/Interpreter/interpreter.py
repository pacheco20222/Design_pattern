# Interpreter Pattern in Python

class Expression:
    def interpret(self, context):
        pass

class Number(Expression):
    def __init__(self, number):
        self.number = number

    def interpret(self, context):
        return self.number

class Add(Expression):
    def __init__(self, left, right):
        self.left = left
        self.right = right

    def interpret(self, context):
        return self.left.interpret(context) + self.right.interpret(context)

class Subtract(Expression):
    def __init__(self, left, right):
        self.left = left
        self.right = right

    def interpret(self, context):
        return self.left.interpret(context) - self.right.interpret(context)

# Usage
expression = Add(Number(1), Add(Number(2), Number(3)))
result = expression.interpret({})
print(result)  # 6