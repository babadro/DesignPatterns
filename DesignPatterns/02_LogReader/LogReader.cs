using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_LogReader
{
    public abstract class LogReader
    {
        private int _currentPosition;

        public IEnumerable<LogEntry> ReadLogEntry()
        {
            return ReadEntries(ref _currentPosition).Select(ParseLogEntry);
        }

        protected abstract IEnumerable<string> ReadEntries(ref int position);

        protected abstract LogEntry ParseLogEntry(string stringEntry);
    }

    public class LogEntry { }
}
