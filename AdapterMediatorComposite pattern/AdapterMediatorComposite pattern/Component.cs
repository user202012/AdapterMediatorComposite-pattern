using System;

abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public abstract void Print();
    public abstract void Save();
}
