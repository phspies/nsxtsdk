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
    public class NSXTNodeType 
    {
        /// <summary>
        /// This field is deprecated. TransportNode field 'display_name' must be used instead. For HostNode, this field defaults to
        /// ID if not set. For EdgeNode and PublicCloudGatewayNode, this field is ignored if specified in request payload.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// This field is deprecated. TransportNode field 'description' must be used instead. For EdgeNode and
        /// PublicCloudGatewayNode, this field is ignored if specified in request payload.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// This field is deprecated. TransportNode field 'tags' must be used instead. For EdgeNode and PublicCloudGatewayNode, this
        /// field is ignored if specified in request payload.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<NSXTTagType> Tags { get; set; }
        /// <summary>
        /// Discovered IP Addresses of the fabric node, version 4 or 6
        /// </summary>
        [JsonProperty(PropertyName = "discovered_ip_addresses")]
        public IList<string> DiscoveredIpAddresses { get; set; }
        /// <summary>
        /// IP Addresses of the Node, version 4 or 6. This property is mandatory for all nodes except for
        /// automatic deployment of edge virtual machine node. For automatic deployment, the ip address from
        /// management_port_subnets property will be considered.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses")]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// ID of the Node maintained on the Node and used to recognize the Node
        /// </summary>
        [JsonProperty(PropertyName = "external_id")]
        public string? ExternalId { get; set; }
        /// <summary>
        /// Fully qualified domain name of the fabric node
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Fabric node type, for example 'HostNode', 'EdgeNode' or 'PublicCloudGatewayNode'
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
        /// <summary>
        /// Unique identifier of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
