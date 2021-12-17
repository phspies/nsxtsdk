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
    public class NSXTALBL4PolicySetApiResponseType : NSXTListResultType
    {
        public NSXTALBL4PolicySetApiResponseType()
        {
        }
        /// <summary>
        /// count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [NSXTProperty(IsRequired: false, Description: @"count")]
        public int? Count { get; set; }
        /// <summary>
        /// Array of L4PolicySet
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Array of L4PolicySet")]
        public IList<NSXTALBL4PolicySetType> Results { get; set; }
    }
}
