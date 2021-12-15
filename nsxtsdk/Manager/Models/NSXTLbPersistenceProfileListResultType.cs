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
    public class NSXTLbPersistenceProfileListResultType : NSXTListResultType
    {
        /// <summary>
        /// paginated list of load balancer persistence profiles
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"paginated list of load balancer persistence profiles")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLbPersistenceProfileType> Results { get; set; }
    }
}
