using System;
namespace Mediator
{
	public class Component2:BaseComponent
	{
		public Component2()
		{
		}

        public void DoC()
        {
            Console.WriteLine("Component2 does C");
            this.mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component2 does D");
            this.mediator.Notify(this, "D");
        }
    }
}

