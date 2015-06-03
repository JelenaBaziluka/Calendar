using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calendar.Test
{
    class ClientParametersRequest
    {
        public int DaysInterval { get; set; }

        public DateTime Finish { get; set; }

        public DateTime Start { get; set; }
    }
}
