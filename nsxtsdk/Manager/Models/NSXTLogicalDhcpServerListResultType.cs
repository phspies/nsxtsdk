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
    public class NSXTLogicalDhcpServerListResultType : NSXTListResultType
    {
        /// <summary>
        /// A paginated list of logical DHCP servers.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A paginated list of logical DHCP servers.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTLogicalDhcpServerType> Results { get; set; }
    }
}
