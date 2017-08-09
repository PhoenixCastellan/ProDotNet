using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.Delegate
{
    public delegate void SaySomeThing(string words);

    public class MyDelegate
    {
        public SaySomeThing SaySomeThing;

        public void Say(string word)
        {
            SaySomeThing?.Invoke(word);
        }
    }
}
