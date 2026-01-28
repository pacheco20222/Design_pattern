abstract class Game
{
    public void Play()
    {
        Start();
        End();
    }

    protected abstract void Start();
    protected abstract void End();
}

class Soccer : Game
{
    protected override void Start() { }
    protected override void End() { }
}
