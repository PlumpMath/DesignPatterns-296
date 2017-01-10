using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BadDurationFactory
    {
        public BadDuration FromTicks(long ticks)
        {
            return new BadDuration(ticks);
        }

        public BadDuration FromMilliseconds(long milliseconds)
        {
            return new BadDuration(milliseconds * 10000);
        }

        public BadDuration FromSeconds(long seconds)
        {
            return new BadDuration(seconds * 10000 * 1000);
        }
    }
}
