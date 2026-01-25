public class Facade {
    protected Subsystem1 _subsystem1;
    protected Subsystem2 _subsystem2;
    public Facade() {
        _subsystem1 = new Subsystem1();
        _subsystem2 = new Subsystem2();
    }
    public string Operation() => "Facade initializes subsystems:\n" + 
                                _subsystem1.operation1() + 
                                _subsystem2.operation1();
}

public class Subsystem1 { public string operation1() => "Subsystem1: Ready!\n"; }
public class Subsystem2 { public string operation1() => "Subsystem2: Go!\n"; }