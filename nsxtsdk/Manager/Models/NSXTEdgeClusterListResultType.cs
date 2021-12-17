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
    public class NSXTEdgeClusterListResultType : NSXTListResultType
    {
        public NSXTEdgeClusterListResultType()
        {
        }
        /// <summary>
        /// Edge cluster list results
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Edge cluster list results")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTEdgeClusterType> Results { get; set; }
    }
}
