class Memento
{
    public string State { get; }
    public Memento(string state) => State = state;
}

class Editor
{
    public string Text = "";

    public Memento Save() => new Memento(Text);
    public void Restore(Memento m) => Text = m.State;
}
