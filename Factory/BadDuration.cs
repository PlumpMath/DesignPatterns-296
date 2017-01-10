using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public sealed class BadDuration
    {
        private readonly long ticks;

        public long Ticks { get { return ticks; } }

        public BadDuration(long ticks)
        {
            this.ticks = ticks;
        }
    }
}
