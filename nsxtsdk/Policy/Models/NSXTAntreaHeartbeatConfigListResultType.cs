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
    public class NSXTAntreaHeartbeatConfigListResultType : NSXTListResultType
    {
        public NSXTAntreaHeartbeatConfigListResultType()
        {
        }
        /// <summary>
        /// List of Antrea cluster heartbeat config.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of Antrea cluster heartbeat config.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTAntreaHeartbeatConfigType> Results { get; set; }
    }
}