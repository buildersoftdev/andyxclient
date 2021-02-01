﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Buildersoft.Andy.X.Client.Abstraction
{
    public abstract partial class ReaderBase<T>
    {
        private class MessageReceivedArgs
        {
            public string MessageId { get; set; }
            public string Tenant { get; set; }
            public string Product { get; set; }
            public string Component { get; set; }
            public string Book { get; set; }

            public object Message { get; set; }
        }
    }
}
