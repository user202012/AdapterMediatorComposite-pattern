using System;
using System.IO;
class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Print()
    {
        Console.WriteLine(name);
    }
    public override void Save()
    {
        string WritePath= @"C:\Users\User\source\repos\AdapterMediatorComposite pattern\AdapterMediatorComposite pattern\test.txt";
        
        using (StreamWriter sw = new StreamWriter(WritePath, true, System.Text.Encoding.Default))
        {
            sw.WriteLine(name);
        }
    }
}
