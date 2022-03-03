using System;

namespace EventDelegateDemo
{
    public delegate void Start();
    class StartProgram
    {

        public event Start completedProcess;

        public void StartProcess()
        {


            Console.WriteLine("Process start");
            Console.ReadLine();
            OncompletedProcess();
        }

        private void OncompletedProcess()
        {
            completedProcess?.Invoke();
        }
    }
}