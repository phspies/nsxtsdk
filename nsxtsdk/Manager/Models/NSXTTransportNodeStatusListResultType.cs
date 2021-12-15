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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportNodeStatusListResultType : NSXTListResultType
    {
        /// <summary>
        /// List of transport node statuses
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"List of transport node statuses")]
        public IList<NSXTTransportNodeStatusType> Results { get; set; }
    }
}
