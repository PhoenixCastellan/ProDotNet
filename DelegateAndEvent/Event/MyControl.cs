using System;

namespace DelegateAndEvent.Event
{
    public delegate void MyEventHandle(object sender, KeyCharArgs e);

    public class MyControl
    {
        public event MyEventHandle on_a_click;
        public event MyEventHandle on_z_click;

        private string _ctlName;

        public MyControl(string name)
        {
            _ctlName = name;
        }

        public void Run()
        {
            Console.WriteLine(_ctlName+@" input a char");

            var isEnd = false;
            while (!isEnd)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        on_a_click?.Invoke(this, new KeyCharArgs(key.KeyChar));
                        break;
                    case ConsoleKey.Z:
                        on_a_click?.Invoke(this, new KeyCharArgs(key.KeyChar));
                        break;
                    case ConsoleKey.Escape:
                        isEnd = true;
                        break;
                }
            }
        }
    }
}
