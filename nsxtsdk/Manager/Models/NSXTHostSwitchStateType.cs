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
    /// Host Switch State
    /// </summary>
    [NSXTProperty(Description: @"Host Switch State")]
    public class NSXTHostSwitchStateType 
    {
        /// <summary>
        /// VDS represents VMware vSphere Distributed Switch from vSphere that is used as HostSwitch through TransportNode or
        /// TransportNodeProfile configuration. When VDS is used as a HostSwitch, Hosts have to be added to VDS from vSphere and VDS
        /// instance is created on Hosts. To configure NSX on such hosts, you can use this VDS as a HostSwitch from NSX manager.
        /// vCenter has the ownership of MTU, LAG, NIOC and LLDP configuration of such VDS backed HostSwitch. Remaining
        /// configuration (e.g. UplinkHostswitchProfile) will be managed by NSX. NVDS represents NSX Virtual Switch which is NSX
        /// native HostSwitch. All configurations of NVDS will be managed by NSX.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostSwitchStateHostSwitchTypeEnumType? HostSwitchType { get; set; }
        /// <summary>
        /// External ID of the HostSwitch
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_id")]
        public string? HostSwitchId { get; set; }
        /// <summary>
        /// List of virtual tunnel endpoints which are configured on this switch
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<NSXTEndpointType> Endpoints { get; set; }
        /// <summary>
        /// List of Ids of TransportZones this HostSwitch belongs to
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_ids")]
        public IList<string> TransportZoneIds { get; set; }
        /// <summary>
        /// The name must be unique among all host switches specified in a given Transport Node.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name")]
        public string? HostSwitchName { get; set; }
    }
}
