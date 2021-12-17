// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// VDS represents VMware vSphere Distributed Switch from vSphere that is used as HostSwitch through TransportNode or TransportNodeProfile configuration. When VDS is used as a HostSwitch, Hosts have to be added to VDS from vSphere and VDS instance is created on Hosts. To configure NSX on such hosts, you can use this VDS as a HostSwitch from NSX manager. vCenter has the ownership of MTU, LAG, NIOC and LLDP configuration of such VDS backed HostSwitch. Remaining configuration (e.g. UplinkHostswitchProfile) will be managed by NSX.NVDS represents NSX Virtual Switch which is NSX native HostSwitch. All configurations of NVDS will be managed by NSX. HostSwitch of type NVDS has been deprecated on ESX hosts that are managed by a vCenter Server.
    /// </summary>
    [NSXTProperty(Description: @"VDS represents VMware vSphere Distributed Switch from vSphere that is used as HostSwitch through TransportNode or TransportNodeProfile configuration. When VDS is used as a HostSwitch, Hosts have to be added to VDS from vSphere and VDS instance is created on Hosts. To configure NSX on such hosts, you can use this VDS as a HostSwitch from NSX manager. vCenter has the ownership of MTU, LAG, NIOC and LLDP configuration of such VDS backed HostSwitch. Remaining configuration (e.g. UplinkHostswitchProfile) will be managed by NSX.NVDS represents NSX Virtual Switch which is NSX native HostSwitch. All configurations of NVDS will be managed by NSX. HostSwitch of type NVDS has been deprecated on ESX hosts that are managed by a vCenter Server.")]
    public enum NSXTStandardHostSwitchHostSwitchTypeEnumType
    {
        [EnumMember(Value = "NVDS")]
        NVDS = 1,
        [EnumMember(Value = "VDS")]
        VDS = 2,
    }
}
