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
    public class NSXTServiceChainMappingListResultType : NSXTListResultType
    {
        public NSXTServiceChainMappingListResultType()
        {
        }
        /// <summary>
        /// List of the Service Chain Mappings. The list has to be homogenous.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"List of the Service Chain Mappings. The list has to be homogenous.")]
        public IList<NSXTServiceChainMappingType> Results { get; set; }
    }
}
