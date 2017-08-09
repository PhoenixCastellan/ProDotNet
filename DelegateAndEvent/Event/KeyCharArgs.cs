using System;

namespace DelegateAndEvent.Event
{
    public class KeyCharArgs:EventArgs
    {
        private readonly char _char;

        public char Char => _char;

        public KeyCharArgs(char keyChar)
        {
            this._char = keyChar;
        }
    }
}
