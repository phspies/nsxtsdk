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
    public class NSXTInterfaceNeighborPropertyListResultType : NSXTListResultType
    {
        public NSXTInterfaceNeighborPropertyListResultType()
        {
        }
        /// <summary>
        /// Interface neighbor property results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Interface neighbor property results")]
        public IList<NSXTInterfaceNeighborPropertiesType> Results { get; set; }
    }
}
