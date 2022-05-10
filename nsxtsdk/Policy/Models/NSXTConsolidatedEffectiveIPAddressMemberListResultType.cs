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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTConsolidatedEffectiveIPAddressMemberListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged Collection of site wise consolidated effective ip addresses for the given NSGroup
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        public IList<NSXTEffectiveIPInfoType> Results { get; set; }
    }
}
