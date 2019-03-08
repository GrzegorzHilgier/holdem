using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    public interface IRecordable
    {
        List<string> History { get; }
        List<string> Status { get; }
        void Add(IRecordable log);
    }
}
