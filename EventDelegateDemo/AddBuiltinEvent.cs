using System;

namespace EventDelegateDemo
{
    class AddBuiltinEvent
    {
        public event EventHandler<EventArgs> Addnumbers;

        public void Add()
        {
            int x;
            x = 100 + 150;
            Console.WriteLine("\n Event Add " + (x));
            Console.Read();
            OnCompletedEvent();

        }

        private void OnCompletedEvent()
        {
            Addnumbers?.Invoke(this, EventArgs.Empty);
            Console.Read();
        }
    }
}