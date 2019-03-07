using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public class FinishEventArgs : EventArgs
    {
        public string Status { get; private set; }

        public FinishEventArgs(string status)
        {
            Status = status;
        }
    }
}
