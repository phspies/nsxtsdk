using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEdgeNodeType : NSXTNodeType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_settings", Required = Required.AllowNull)]
        public NSXTEdgeNodeSettingsType NodeSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_config")]
        public NSXTEdgeNodeDeploymentConfigType DeploymentConfig { get; set; }
        /// <summary>
        /// List of logical router ids to which this edge node is allocated.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_list")]
        public IList<string> AllocationList { get; set; }
        /// <summary>
        /// Supported edge deployment type.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeNodeDeploymentTypeEnumType? DeploymentType { get; set; }
    }
}
