using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Collection of all registered ErrorResolverInfo
    /// </summary>
    [NSXTProperty(Description: @"Collection of all registered ErrorResolverInfo")]
    public class NSXTErrorResolverInfoListType 
    {
        /// <summary>
        /// ErrorResolverInfo list
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTErrorResolverInfoType> Results { get; set; }
    }
}
