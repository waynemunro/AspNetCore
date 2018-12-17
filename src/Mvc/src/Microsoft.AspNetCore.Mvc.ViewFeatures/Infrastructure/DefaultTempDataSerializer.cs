// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure
{
    public sealed class DefaultTempDataSerializer : TempDataSerializer
    {
        public override IDictionary<string, object> Deserialize(byte[] unprotectedData)
        {
            throw new NotSupportedException("This will get fixed eventually.");
        }

        public override byte[] Serialize(IDictionary<string, object> values)
        {
            throw new NotSupportedException("This will get fixed eventually.");
        }
    }
}
