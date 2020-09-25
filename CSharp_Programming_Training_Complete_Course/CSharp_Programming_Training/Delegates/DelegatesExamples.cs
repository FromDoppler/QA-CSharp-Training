using System;

namespace QA_CSharp_Programming_Training.Delegates
{
    public delegate void NotificationDelegate(string message);

    public class DelegatesExamples
    {
        private void NotifyMom(string message)
        {
            Console.WriteLine($"Sending message to mom: {message}");
        }

        private void NotifyDaddy(string message)
        {
            Console.WriteLine($"Sending message to daddy: {message}");
        }

        private void NotifyAFriend(string message)
        {
            Console.WriteLine($"Sending message to my friend: {message}");
        }

        public void ExecuteSimpleDelegateExample()
        {
            NotificationDelegate notifier;

            notifier = NotifyMom;
            notifier += NotifyDaddy;
            notifier += NotifyAFriend;

            notifier("Birthday party at home on Friday! See you there!!!");

            notifier -= NotifyAFriend;
            notifier("I'll see you at Christmas!!");
        }
    }
}
