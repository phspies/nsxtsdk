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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDataSourceParametersType 
    {
        /// <summary>
        /// The data source, either realtime or cached. If not provided, cached data is returned.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"The data source, either realtime or cached. If not provided, cached data is returned.")]
        public NSXTDataSourceParametersSourceEnumType? Source { get; set; }
    }
}