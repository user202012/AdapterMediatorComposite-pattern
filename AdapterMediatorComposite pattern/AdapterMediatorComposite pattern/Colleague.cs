using System;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.IO;

abstract class Colleague
{
    protected Mediator mediator;

    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }
}

class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator) : base(mediator)
    {
    }

    public void Get(string input)
    {
        mediator.Transfer(input, this);
    }

    public void PrintHash(string input)
    {
        SHA256 SHA256 = SHA256.Create();
        byte[] data = SHA256.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}

class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator): base(mediator)
    {
    }

    public void Get(string input)
    {

        mediator.Transfer(input, this);
    }

    public void PrintHash(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        Console.WriteLine(sBuilder.ToString());
    }
}
