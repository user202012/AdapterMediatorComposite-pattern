using System;

abstract class Mediator
{
    public abstract void Transfer(string input, Colleague colleague);
}

class ConcreteMediator : Mediator
{
    public ConcreteColleague1 Colleague1 { private get; set; }

    public ConcreteColleague2 Colleague2 { private get; set; }

    public override void Transfer(string input, Colleague colleague)
    {
        if (colleague == Colleague1)
        {
            Colleague2.PrintHash(input);
        }
        else
        {
            Colleague1.PrintHash(input);
        }
    }
}
