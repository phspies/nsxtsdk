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
    /// IDS event flow data specific to each IDS
        /// event. The data includes source ip, source
        /// port, destination ip, destination port,
        /// protocol, rule id, profile id, and the
        /// action.
    /// </summary>
    [NSXTProperty(Description: @"IDS event flow data specific to each IDSevent. The data includes source ip, sourceport, destination ip, destination port,protocol, rule id, profile id, and theaction.")]
    public class NSXTPolicyIdsEventFlowDataType 
    {
        public NSXTPolicyIdsEventFlowDataType()
        {
        }
        /// <summary>
        /// IP address of the destination VM on the intrusion flow.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of the destination VM on the intrusion flow.")]
        public string? DestinationIp { get; set; }
        /// <summary>
        /// Traffic protocol pertaining to the detected intrusion, could be TCP/UDP etc.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"Traffic protocol pertaining to the detected intrusion, could be TCP/UDP etc.")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Bytes sent to server.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_toserver")]
        [NSXTProperty(IsRequired: false, Description: @"Bytes sent to server.")]
        public long? BytesToserver { get; set; }
        /// <summary>
        /// IP address of VM on the host where IDS engine is running.
        /// </summary>
        [JsonProperty(PropertyName = "local_vm_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of VM on the host where IDS engine is running.")]
        public string? LocalVmIp { get; set; }
        /// <summary>
        /// The IDS profile id that is associated with the IDS rule pertaining to the intrusion event detected.
        /// </summary>
        [JsonProperty(PropertyName = "profile_id")]
        [NSXTProperty(IsRequired: false, Description: @"The IDS profile id that is associated with the IDS rule pertaining to the intrusion event detected.")]
        public string? ProfileId { get; set; }
        /// <summary>
        /// IP address of the source VM on the intrusion flow.
        /// </summary>
        [JsonProperty(PropertyName = "source_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of the source VM on the intrusion flow.")]
        public string? SourceIp { get; set; }
        /// <summary>
        /// IP address of the VM that initiated the communication.
        /// </summary>
        [JsonProperty(PropertyName = "client_ip")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of the VM that initiated the communication.")]
        public string? ClientIp { get; set; }
        /// <summary>
        /// Tags associated with the gateway on which this intrusion was detected.
        /// </summary>
        [JsonProperty(PropertyName = "gateway_tags")]
        [NSXTProperty(IsRequired: false, Description: @"Tags associated with the gateway on which this intrusion was detected.")]
        public IList<NSXTTagType> GatewayTags { get; set; }
        /// <summary>
        /// The IDS Rule id pertaining to the detected intrusion.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"The IDS Rule id pertaining to the detected intrusion.")]
        public long? RuleId { get; set; }
        /// <summary>
        /// Name of the host on which this intrusion was detected.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the host on which this intrusion was detected.")]
        public string? Host { get; set; }
        /// <summary>
        /// The action pertaining to the detected intrusion. Possible values are ALERT, DROP, REJECT, and INVALID. ALERT - If there
        /// is a signature match on the packet, it is allowed to pass but a notification is sent to the user notifying an intrusion
        /// was detected. DROP - On a signature match, the packet is silently dropped. An alert is sent to the user that an
        /// intrusion was detected. REJECT - On a signature match, the packet is dropped and TCP RST or ICMP error messages (for
        /// non-TCP pkts) are sent to the endpoints. An alert is sent to the user that an intrusion was detected. INVALID - If the
        /// action doesn't belong to any of the above mentioned categories, it is marked as INVALID.
        /// </summary>
        [JsonProperty(PropertyName = "action_type")]
        [NSXTProperty(IsRequired: false, Description: @"The action pertaining to the detected intrusion. Possible values are ALERT, DROP, REJECT, and INVALID. ALERT - If there is a signature match on the packet, it is allowed to pass but a notification is sent to the user notifying an intrusion was detected. DROP - On a signature match, the packet is silently dropped. An alert is sent to the user that an intrusion was detected. REJECT - On a signature match, the packet is dropped and TCP RST or ICMP error messages (for non-TCP pkts) are sent to the endpoints. An alert is sent to the user that an intrusion was detected. INVALID - If the action doesn&apos;t belong to any of the above mentioned categories, it is marked as INVALID.")]
        public NSXTPolicyIdsEventFlowDataActionTypeEnumType? ActionType { get; set; }
        /// <summary>
        /// The source where the intrusion was detected. Possible values are GATEWAY and HOST.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_type")]
        [NSXTProperty(IsRequired: false, Description: @"The source where the intrusion was detected. Possible values are GATEWAY and HOST.")]
        public NSXTPolicyIdsEventFlowDataTrafficTypeEnumType? TrafficType { get; set; }
        /// <summary>
        /// Source port through which traffic was initiated that caused the intrusion to be detected.
        /// </summary>
        [JsonProperty(PropertyName = "source_port")]
        [NSXTProperty(IsRequired: false, Description: @"Source port through which traffic was initiated that caused the intrusion to be detected.")]
        public long? SourcePort { get; set; }
        /// <summary>
        /// Bytes sent to client.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_toclient")]
        [NSXTProperty(IsRequired: false, Description: @"Bytes sent to client.")]
        public long? BytesToclient { get; set; }
        /// <summary>
        /// Port on the destination VM where the traffic was sent to.
        /// </summary>
        [JsonProperty(PropertyName = "destination_port")]
        [NSXTProperty(IsRequired: false, Description: @"Port on the destination VM where the traffic was sent to.")]
        public long? DestinationPort { get; set; }
        /// <summary>
        /// Name of the gateway on which this intrusion was detected.
        /// </summary>
        [JsonProperty(PropertyName = "gateway")]
        [NSXTProperty(IsRequired: false, Description: @"Name of the gateway on which this intrusion was detected.")]
        public string? Gateway { get; set; }
    }
}
