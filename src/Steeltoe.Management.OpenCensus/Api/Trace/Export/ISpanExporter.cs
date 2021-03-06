﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Steeltoe.Management.Census.Trace.Export
{
    [Obsolete("Use OpenCensus project packages")]
    public interface ISpanExporter : IDisposable
    {
        void AddSpan(ISpan span);
        void RegisterHandler(string name, IHandler handler);
        void UnregisterHandler(string name);
    }
}
