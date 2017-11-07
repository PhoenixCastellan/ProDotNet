using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyEvent
{
    internal class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail; 

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            e.Raise(this, ref NewMail);
        }

        public void SimulateNewMail(string from,string to,string subject)
        {
            NewMailEventArgs args = new NewMailEventArgs(from, to, subject);
            OnNewMail(args);
        }
    }A


    public static class EventArgsExtensions
    {
        public static void Raise<TEventArgs>(this TEventArgs e,object sender,ref EventHandler<TEventArgs> eventDelegate)
        {
            EventHandler<TEventArgs> temp = Volatile.Read(ref eventDelegate);
            if (temp != null)
            {
                temp(sender, e);
            }
        }
    }
}
