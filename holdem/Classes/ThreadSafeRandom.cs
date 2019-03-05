using System;
using System.Threading;

namespace holdem
{
    internal static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        internal static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

}
