using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    class Todo
    {
        public String Description { get; set; }
        public int Hours { get; set; }
        public Status status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Compleated,
        Deleted
    }
}