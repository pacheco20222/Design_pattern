# Mediator Design Pattern

The Mediator design pattern defines an object that encapsulates how a set of objects interact. It promotes loose coupling by keeping objects from referring to each other explicitly and lets you vary their interaction independently.

## Key Components
- **Mediator**: Defines an interface for communicating with Colleague objects.
- **ConcreteMediator**: Implements cooperative behavior by coordinating Colleague objects.
- **Colleague classes**: Each Colleague class knows its Mediator object and communicates with it instead of other Colleagues.

## When to Use
- When objects communicate in complex but well-defined ways.
- When reusing objects is difficult because they refer to and communicate with many other objects.
- When a behavior distributed among several classes should be customizable without a lot of subclassing.

## Example
In this example, we have a chat room where users communicate through a mediator.

UML link: https://www.canva.com/design/DAG_qQcToDA/QDWmKnIC8MWihb4i3UkXvg/edit?utm_content=DAG_qQcToDA&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton
