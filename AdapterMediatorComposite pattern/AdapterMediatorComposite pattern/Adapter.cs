using System;

class Adapter : Adaptee, ITarget
{
    private Adaptee adaptee = new Adaptee();
    public void Request(string input)
    {
        adaptee.SpecificHash(input);
    }
}
