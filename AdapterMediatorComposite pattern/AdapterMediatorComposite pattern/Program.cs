using System;

namespace AdapterMediatorComposite_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";

            Adapter adapter = new Adapter();
            adapter.Request(input);

            ConcreteMediator Mediator = new ConcreteMediator();

            ConcreteColleague1 Colleague1 = new ConcreteColleague1(Mediator);
            ConcreteColleague2 Colleague2 = new ConcreteColleague2(Mediator);

            Mediator.Colleague1 = Colleague1;
            Mediator.Colleague2 = Colleague2;

            Colleague1.PrintHash(input);
            Colleague2.PrintHash(input);

            Composite root = new Composite("Hello World");

            root.Add(new Leaf("John"));
            root.Add(new Leaf("Smith"));
            Leaf Private = new Leaf("Password");
            root.Add(Private);
            root.Print();
            root.Remove(Private);
            root.Save();
        }
    }
}
