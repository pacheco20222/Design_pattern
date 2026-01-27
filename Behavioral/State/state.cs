interface State
{
    void Handle(Context context);
}

class Context
{
    public State State;
    public Context(State state) => State = state;
    public void Request() => State.Handle(this);
}

class OnState : State
{
    public void Handle(Context context)
    {
        context.State = new OffState();
    }
}

class OffState : State
{
    public void Handle(Context context)
    {
        context.State = new OnState();
    }
}
