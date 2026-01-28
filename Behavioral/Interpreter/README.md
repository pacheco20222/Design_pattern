# Interpreter Design Pattern

The Interpreter design pattern provides a way to evaluate language grammar or expressions. It defines a representation for a grammar along with an interpreter that uses the representation to interpret sentences in the language.

## Key Components
- **AbstractExpression**: Declares an abstract Interpret operation that is common to all nodes in the abstract syntax tree.
- **TerminalExpression**: Implements an Interpret operation associated with terminal symbols in the grammar.
- **NonterminalExpression**: One such class is required for every rule in the grammar.
- **Context**: Contains information global to the interpreter.

## When to Use
- When you have a language to interpret, and you can represent statements in the language as abstract syntax trees.
- When the grammar is simple.
- When efficiency is not a critical concern.

## Example
In this example, we interpret simple mathematical expressions like "1 + 2 + 3".