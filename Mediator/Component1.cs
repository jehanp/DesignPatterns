using System;
namespace Mediator
{
	public class Component1:BaseComponent
	{
		public Component1()
		{
		}

		public void DoA()
		{
			Console.WriteLine("Component1 does A");
			this.mediator.Notify(this, "A");
		}

        public void DoB()
        {
            Console.WriteLine("Component1 does B");
            this.mediator.Notify(this, "B");
        }
    }
}

