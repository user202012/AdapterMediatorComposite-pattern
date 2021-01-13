using System;
using System.Collections.Generic;
using System.Threading;
class Composite : Component
{
    private List<Component> container = new List<Component>();

    public Composite(string name) : base(name)
    {
    }

    public void Add(Component component)
    {
        container.Add(component);
    }

    public void Remove(Component component)
    {
        container.Remove(component);
    }

    public override void Print()
    {
        foreach (Component component in container)
        {
            component.Print();
        }
    }
    public override void Save()
    {
        foreach (Component component in container)
        {
            component.Save();
        }
    }
}