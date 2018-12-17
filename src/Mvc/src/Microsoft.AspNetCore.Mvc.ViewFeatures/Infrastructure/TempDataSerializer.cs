// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures.Infrastructure
{
    public abstract class TempDataSerializer
    {
        public abstract IDictionary<string, object> Deserialize(byte[] unprotectedData);

        public abstract byte[] Serialize(IDictionary<string, object> values);
    }
}
