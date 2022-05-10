using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// A list of fields to include in query results
    /// </summary>
    [NSXTProperty(Description: @"A list of fields to include in query results")]
    public class NSXTIncludedFieldsParametersType 
    {
        /// <summary>
        /// Note - this parameter currently only works when used with the search APIs /policy/api/v1/search/query and
        /// /policy/api/v1/search/dsl. It is ignored for other list APIs.
        /// </summary>
        [JsonProperty(PropertyName = "included_fields")]
        public string? IncludedFields { get; set; }
    }
}
