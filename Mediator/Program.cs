
using System.Threading.Tasks;
using Mediator;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("MediatorPattern");

var c1 = new Component1();
var c2 = new Component2();

new ConcreteMediator(c1, c2);

Console.WriteLine("Client triggers operation A");
c1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D");
c2.DoD();

