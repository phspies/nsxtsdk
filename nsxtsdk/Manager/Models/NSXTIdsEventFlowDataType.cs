// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// IDS event flow data specific to each IDS
        /// event. The data includes source ip, source
        /// port, destination ip, destination port,
        /// protocol, rule id, profile id, and the
        /// action.
    /// </summary>
    [NSXTProperty(Description: @"IDS event flow data specific to each IDSevent. The data includes source ip, sourceport, destination ip, destination port,protocol, rule id, profile id, and theaction.")]
    public class NSXTIdsEventFlowDataType 
    {
        /// <summary>
        /// IP address of the destination VM on the intrusion flow.
        /// </summary>
        public string? DestinationIp { get; set; }
        /// <summary>
        /// Traffic protocol pertaining to the detected intrusion, could be TCP/UDP etc.
        /// </summary>
        public string? Protocol { get; set; }
        /// <summary>
        /// Bytes sent to server.
        /// </summary>
        public long? BytesToserver { get; set; }
        /// <summary>
        /// IP address of VM on the host where IDS engine is running.
        /// </summary>
        public string? LocalVmIp { get; set; }
        /// <summary>
        /// The IDS profile id that is associated with the IDS rule pertaining to the intrusion event detected.
        /// </summary>
        public string? ProfileId { get; set; }
        /// <summary>
        /// IP address of the source VM on the intrusion flow.
        /// </summary>
        public string? SourceIp { get; set; }
        /// <summary>
        /// IP address of the VM that initiated the communication.
        /// </summary>
        public string? ClientIp { get; set; }
        /// <summary>
        /// The action pertaining to the detected intrusion. Possible values are ALERT, DROP, REJECT, and INVALID. ALERT - If there
        /// is a signature match on the packet, it is allowed to pass but a notification is sent to the user notifying an intrusion
        /// was detected. DROP - On a signature match, the packet is silently dropped. An alert is sent to the user that an
        /// intrusion was detected. REJECT - On a signature match, the packet is dropped and TCP RST or ICMP error messages (for
        /// non-TCP pkts) are sent to the endpoints. An alert is sent to the user that an intrusion was detected. INVALID - If the
        /// action doesn't belong to any of the above mentioned categories, it is marked as INVALID.
        /// </summary>
        public NSXTIdsEventFlowDataActionTypeEnumType? ActionType { get; set; }
        /// <summary>
        /// Source port through which traffic was initiated that caused the intrusion to be detected.
        /// </summary>
        public long? SourcePort { get; set; }
        /// <summary>
        /// Bytes sent to client.
        /// </summary>
        public long? BytesToclient { get; set; }
        /// <summary>
        /// Port on the destination VM where the traffic was sent to.
        /// </summary>
        public long? DestinationPort { get; set; }
        /// <summary>
        /// The IDS Rule id pertaining to the detected intrusion.
        /// </summary>
        public long? RuleId { get; set; }
    }
}
