using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
     internal sealed class Fax
    {
        public Fax(MailManager mailManager)
        {
            mailManager.NewMail += FaxMsg;
        }
        private void FaxMsg(object sender,NewMailEventArgs e)
        {
            Console.WriteLine("Faxing mail message:");
            Console.WriteLine("From={0},To={1},Subject={2}", e.From, e.To, e.Subject);
        }

        public void UnRegister(MailManager mm)
        {
            mm.NewMail -= FaxMsg;
        }
    }
}
