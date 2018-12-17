// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.AspNetCore.Mvc.NewtonsoftJson
{
    internal class AnnotatedProblemDetails
    {
        public AnnotatedProblemDetails() { }

        public AnnotatedProblemDetails(ProblemDetails problemDetails)
        {
            Detail = problemDetails.Detail;
            Instance = problemDetails.Instance;
            Status = problemDetails.Status;
            Title = problemDetails.Title;
            Type = problemDetails.Type;

            foreach (var kvp in problemDetails.Extensions)
            {
                Extensions[kvp.Key] = kvp.Value;
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public int? Status { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detail")]
        public string Detail { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instance")]
        public string Instance { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> Extensions { get; } = new Dictionary<string, object>(StringComparer.Ordinal);

        public void CopyTo(ProblemDetails problemDetails)
        {
            problemDetails.Type = Type;
            problemDetails.Title = Title;
            problemDetails.Status = Status;
            problemDetails.Instance = Instance;
            problemDetails.Detail = Detail;

            foreach (var kvp in Extensions)
            {
                problemDetails.Extensions[kvp.Key] = kvp.Value;
            }
        }
    }
}
