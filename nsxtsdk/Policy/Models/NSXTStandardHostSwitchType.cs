using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Standard host switch specification
    /// </summary>
    [NSXTProperty(Description: @"Standard host switch specification")]
    public class NSXTStandardHostSwitchType 
    {
        /// <summary>
        /// VDS represents VMware vSphere Distributed Switch from vSphere that is used as HostSwitch through TransportNode or
        /// TransportNodeProfile configuration. When VDS is used as a HostSwitch, Hosts have to be added to VDS from vSphere and VDS
        /// instance is created on Hosts. To configure NSX on such hosts, you can use this VDS as a HostSwitch from NSX manager.
        /// vCenter has the ownership of MTU, LAG, NIOC and LLDP configuration of such VDS backed HostSwitch. Remaining
        /// configuration (e.g. UplinkHostswitchProfile) will be managed by NSX.
        /// NVDS represents NSX Virtual Switch which is NSX native HostSwitch. All configurations of NVDS will be managed by NSX.
        /// HostSwitch of type NVDS has been deprecated on ESX hosts that are managed by a vCenter Server.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTStandardHostSwitchHostSwitchTypeEnumType? HostSwitchType { get; set; }
        /// <summary>
        /// This is only supported for NVDS type of host switch. If this is specified for VDS type of host switch, an error will be
        /// returned to user. The pnics to be migrated out to a non N-VDS switch during transport node deletion.
        /// </summary>
        [JsonProperty(PropertyName = "pnics_uninstall_migration")]
        public IList<NSXTPnicType> PnicsUninstallMigration { get; set; }
        /// <summary>
        /// If VDS is used as a HostSwitch this attribute must be specified. You can associate uplinks from UplinkHostSwitchProfile
        /// to either VDS uplink or LAG. VDS uplink or LAG will inherit the global VDS level teaming policy from vSphere. NSX
        /// managed uplink or LAG will have NSX teaming policy configured through UplinkHostSwitchProfile.
        /// </summary>
        [JsonProperty(PropertyName = "uplinks")]
        public IList<NSXTVdsUplinkType> Uplinks { get; set; }
        /// <summary>
        /// This field is writable only in case of NVDS type HostSwitch and system generated for VDS type. For NVDS type host
        /// switch, If this name is unset or empty then the default host switch name will be used. The name must be unique among all
        /// host switches specified in a given transport node; unset name, empty name and the default host switch name are
        /// considered the same in terms of uniqueness. For VDS type host switch, Manager fetches VDS name from corresponding
        /// Compute Manager and populates this field. If VDS name is given (correct or incorrect) it is ignored and overwritten with
        /// correct one.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name")]
        public string? HostSwitchName { get; set; }
        /// <summary>
        /// This field is writable only in case of VDS type HostSwitch and system generated for NVDS type. For VDS type host switch,
        /// This field is used to lookup a VDS from corresponding Compute Manager and then can be configured for logical networking.
        /// For NVDS type host switch, This field is system generated and if provided will be overwritten.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_id")]
        public string? HostSwitchId { get; set; }
        /// <summary>
        /// List of TransportZones that are to be associated with specified host switch.
        /// If this property is specified, host_switch_mode at StandardHostSwitch level must be specified.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_endpoints")]
        public IList<NSXTTransportZoneEndPointType> TransportZoneEndpoints { get; set; }
        /// <summary>
        /// A transport zone will be created for each DVS found across all hosts in a cluster that is installed for NSX on DVPG.
        /// This field, populated by NSX, is the ID of the transport zone created for the DVS this host switch represents. All
        /// discovered segments created for the DVPGs found on the DVS will have this ID specified as the transport zone id.
        /// </summary>
        [JsonProperty(PropertyName = "portgroup_transport_zone_id")]
        public string? PortgroupTransportZoneId { get; set; }
        /// <summary>
        /// This is only supported for NVDS type of host switch. If this is specified for VDS type of host switch, an error will be
        /// returned to user. The vmk interfaces and the associated logical switches on the host switch. The state of this field is
        /// realized on the transport node during creation and update.
        /// </summary>
        [JsonProperty(PropertyName = "vmk_install_migration")]
        public IList<NSXTVmknicNetworkType> VmkInstallMigration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_assignment_spec")]
        public NSXTIpAssignmentSpecType IpAssignmentSpec { get; set; }
        /// <summary>
        /// CPU configuration specifies number of Logical cpu cores (Lcores) per Non Uniform Memory Access (NUMA) node dedicated to
        /// Enhanced Networking Stack enabled HostSwitch to get the best performance.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_config")]
        public IList<NSXTCpuCoreConfigForEnhancedNetworkingStackSwitchType> CpuConfig { get; set; }
        /// <summary>
        /// If the pnics specified in the pnics field are used by a single Vsphere Standard Switch or DVS, then migrate the pnics to
        /// N-VDS. If any two pnics are not used by the same Vsphere Standard Switch or DVS, it is not supported. In such cases,
        /// please migrate them in multiple steps, one Vsphere Standard Switch or DVS at a time.
        /// </summary>
        [JsonProperty(PropertyName = "is_migrate_pnics")]
        public bool? IsMigratePnics { get; set; }
        /// <summary>
        /// This is only supported for NVDS type of host switch. If this is specified for VDS type of host switch, an error will be
        /// returned to user. The vmk interfaces and the associated portgroups on the VSS/DVS. This field is realized on the host
        /// during transport node deletion or NSX uninstallation to specify the destination for all vmks on N-VDS switches.
        /// </summary>
        [JsonProperty(PropertyName = "vmk_uninstall_migration")]
        public IList<NSXTVmknicNetworkType> VmkUninstallMigration { get; set; }
        /// <summary>
        /// Pnics are specified when HostSwitch is of type NVDS. When using the Quick Start workflow on 7.0 clusters, pnic
        /// information will be populated by the recommendation when providing a VDS HostSwitch based on a VSS HostSwitch.
        /// </summary>
        [JsonProperty(PropertyName = "pnics")]
        public IList<NSXTPnicType> Pnics { get; set; }
        /// <summary>
        /// STANDARD - This mode applies to all the hypervisors. ENS - This is the Enhanced Data Path switch mode. This mode
        /// provides accelerated networking performances but also introduces additional prerequisites. In order to benefit from this
        /// mode, workloads will be need to be compiled with DPDK and will use VMXNET3 for their vNIC. This mode is only available
        /// on ESX hypervisor (6.7 and above, recommended 6.7 U2 and above) and unavailable on KVM, EDGE and Public Cloud Gateway.
        /// Not all NSX features are available in this mode, please consult the documentation. ENS_INTERRUPT - This is an interrupt
        /// driven variant of the Enhanced Data Path mode. Please, consult your account representative for applicability. This mode
        /// is available only on ESX hypervisor (7.0 and above).
        /// If this property is specified, transport_zone_endpoints must be specified at StandardHostSwitch level.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTStandardHostSwitchHostSwitchModeEnumType? HostSwitchMode { get; set; }
        /// <summary>
        /// Host switch profiles bound to this host switch. If a profile ID is not provided for any HostSwitchProfileType that is
        /// supported by the transport node, the corresponding default profile will be bound to the host switch. If transport node
        /// is created using Policy APIs, use policyPaths instead of UUIDs.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_profile_ids")]
        public IList<NSXTHostSwitchProfileTypeIdEntryType> HostSwitchProfileIds { get; set; }
    }
}
