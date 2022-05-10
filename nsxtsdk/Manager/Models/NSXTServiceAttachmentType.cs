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
    public class NSXTServiceAttachmentType : NSXTManagedResourceType
    {
        /// <summary>
        /// List of LogicalRouters to be connected to the ServicePlane logical switch via a ServiceLink.
        /// </summary>
        [JsonProperty(PropertyName = "logical_routers")]
        public IList<NSXTResourceReferenceType> LogicalRouters { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch")]
        public NSXTResourceReferenceType LogicalSwitch { get; set; }
        /// <summary>
        /// Local IPs associated with this Service Attachment.
        /// </summary>
        [JsonProperty(PropertyName = "local_ips")]
        public IList<NSXTIPInfoType> LocalIps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "service_port")]
        public NSXTResourceReferenceType ServicePort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployed_to", Required = Required.AllowNull)]
        public NSXTResourceReferenceType DeployedTo { get; set; }
        /// <summary>
        /// UP - A Service Attachment will have its Service Port - UP and with a configured IP address. DOWN - An Inactive
        /// ServiceAttachment has its Service Port - DOWN. It can be used to connect set of appliances that do not need to exchange
        /// traffic to/from/through the Edge node.
        /// </summary>
        [JsonProperty(PropertyName = "attachment_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceAttachmentAttachmentStatusEnumType? AttachmentStatus { get; set; }
    }
}
