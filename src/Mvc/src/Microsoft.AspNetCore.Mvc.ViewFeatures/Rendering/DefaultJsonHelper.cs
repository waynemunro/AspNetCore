// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Html;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public sealed class DefaultJsonHelper : IJsonHelper
    {
        /// <inheritdoc />
        public IHtmlContent Serialize(object value)
        {
            throw new NotSupportedException();
        }
    }
}
