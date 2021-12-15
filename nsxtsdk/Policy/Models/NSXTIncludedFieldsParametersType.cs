// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// A list of fields to include in query results
    /// </summary>
    [NSXTProperty(Description: @"A list of fields to include in query results")]
    public class NSXTIncludedFieldsParametersType 
    {
        /// <summary>
        /// Comma separated list of fields that should be included in query result
        /// </summary>
        [JsonProperty(PropertyName = "included_fields")]
        [NSXTProperty(IsRequired: false, Description: @"Comma separated list of fields that should be included in query result")]
        public string? IncludedFields { get; set; }
    }
}