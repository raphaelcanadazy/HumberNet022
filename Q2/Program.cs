using System.ComponentModel;

namespace Q2
{

    public class Program
    {
        public delegate void EventHandler(string name, int value);
        // 1.create a class to pass as an argument for the event handlers (EventArgs class)
        public class Q2EventArgs: EventArgs
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public Q2EventArgs(string name, int value) 
            {
                this.Name = name;
                this.Value = value;
            }
        }

        public class  Q2Publisher
        {
            public event EventHandler<Q2EventArgs> Q2Pub;

            public void Publish(Q2EventArgs e)
            {
                Raise(e);
            }

            protected virtual void Raise(Q2EventArgs e)
            {
                Q2Pub?.Invoke(this, e);
            }
        }

        public class Q2Subscriber
        {
            public void Q2Action(object sender, Q2EventArgs e)
            {
                Console.WriteLine("Q2Subscriber successed");
            }
        }

        static void Main(string[] args)
        {
            //
        }
    }
}
