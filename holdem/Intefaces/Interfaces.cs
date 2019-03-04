using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    interface ILoggable
    {
        List<Log> GetLog();
        Status GetStatus(); 
    }
}
