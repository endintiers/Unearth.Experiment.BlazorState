using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Unearth.Experiment.BlazorStateNoAuth.Services
{
    public class ScopedState
    {
        public Guid Guid { get; set; }
        public int CurrentCount { get; set; }
        public ScopedState()
        {
            Guid = Guid.NewGuid();
            Debug.WriteLine($"Guid: {Guid}");
            CurrentCount = 0;
        }
    }
}
