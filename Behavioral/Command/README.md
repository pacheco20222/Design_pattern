# Command Design Pattern

The Command design pattern encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and logging of the requests. It also allows for the support of undoable operations.

## Key Components
- **Command**: Declares an interface for executing an operation.
- **ConcreteCommand**: Defines a binding between a Receiver object and an action. Implements Execute by invoking the corresponding operation(s) on Receiver.
- **Client**: Creates a ConcreteCommand object and sets its receiver.
- **Invoker**: Asks the command to carry out the request.
- **Receiver**: Knows how to perform the operations associated with carrying out a request.

## When to Use
- When you need to parameterize objects with operations.
- When you need to queue operations, schedule their execution, or execute them remotely.
- When you need to support undo operations.

## Example
In this example, we have a simple remote control that can turn a light on and off using command objects.

UML link: https://www.canva.com/design/DAG_qQcToDA/QDWmKnIC8MWihb4i3UkXvg/edit?utm_content=DAG_qQcToDA&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton
