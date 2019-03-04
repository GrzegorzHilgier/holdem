using System;
using System.Collections.Generic;
using System.Text;

namespace holdem
{
    interface ILoggable
    {
        string GetLog();
        string GetStatus();
        ViewData GetViewData();
    }
}
