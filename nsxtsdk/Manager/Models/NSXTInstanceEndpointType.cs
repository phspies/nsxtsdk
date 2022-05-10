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
    public class NSXTInstanceEndpointType : NSXTManagedResourceType
    {
        /// <summary>
        /// Id(s) of the Service Attachment where this enndpoint is connected to. Service Attachment is mandatory for LOGICAL
        /// Instance Endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "service_attachments")]
        public IList<NSXTResourceReferenceType> ServiceAttachments { get; set; }
        /// <summary>
        /// Target IPs on an interface of the Service Instance.
        /// </summary>
        [JsonProperty(PropertyName = "target_ips", Required = Required.AllowNull)]
        public IList<NSXTIPInfoType> TargetIps { get; set; }
        /// <summary>
        /// LOGICAL - It must be created with a ServiceAttachment and identifies a destination connected to the Service Port of the
        /// ServiceAttachment, through the ServiceAttachment's Logical Switch. VIRTUAL - It represents a L3 destination the router
        /// can route to but does not provide any further information about its location in the network. Virtual InstanceEndpoints
        /// are used for redirection targets that are not connected to Service Ports, such as the next-hop routers on the Edge
        /// uplinks.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTInstanceEndpointEndpointTypeEnumType? EndpointType { get; set; }
        /// <summary>
        /// The Service instancee with which the instance endpoint is associated.
        /// </summary>
        [JsonProperty(PropertyName = "service_instance_id")]
        public string? ServiceInstanceId { get; set; }
        /// <summary>
        /// Link Ids are mandatory for VIRTUAL Instance Endpoint. Even though VIRTUAL, the Instance Endpoint should be
        /// connected/accessible through an NSX object. The link id is this NSX object id. Example - For North-South Service
        /// Insertion, this is the LogicalRouter Id through which the targetIp/L3 destination accessible.
        /// </summary>
        [JsonProperty(PropertyName = "link_ids")]
        public IList<NSXTResourceReferenceType> LinkIds { get; set; }
    }
}
