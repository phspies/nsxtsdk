// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK,CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER,CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.Allowed in Basic(Allowed values- CLOUD_NONE,CLOUD_NSXT)edition, Essentials(Allowed values-CLOUD_NONE,CLOUD_VCENTER) edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as CLOUD_NONE.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK,CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER,CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.Allowed in Basic(Allowed values- CLOUD_NONE,CLOUD_NSXT)edition, Essentials(Allowed values-CLOUD_NONE,CLOUD_VCENTER) edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as CLOUD_NONE.")]
    public enum NSXTAlbvirtualServiceCloudTypeEnumType
    {
        [EnumMember(Value = "CLOUD_NONE")]
        CLOUDNONE = 1,
        [EnumMember(Value = "CLOUD_VCENTER")]
        CLOUDVCENTER = 2,
        [EnumMember(Value = "CLOUD_OPENSTACK")]
        CLOUDOPENSTACK = 3,
        [EnumMember(Value = "CLOUD_AWS")]
        CLOUDAWS = 4,
        [EnumMember(Value = "CLOUD_VCA")]
        CLOUDVCA = 5,
        [EnumMember(Value = "CLOUD_APIC")]
        CLOUDAPIC = 6,
        [EnumMember(Value = "CLOUD_MESOS")]
        CLOUDMESOS = 7,
        [EnumMember(Value = "CLOUD_LINUXSERVER")]
        CLOUDLINUXSERVER = 8,
        [EnumMember(Value = "CLOUD_DOCKER_UCP")]
        CLOUDDOCKERUCP = 9,
        [EnumMember(Value = "CLOUD_RANCHER")]
        CLOUDRANCHER = 10,
        [EnumMember(Value = "CLOUD_OSHIFT_K8S")]
        CLOUDOSHIFTK8S = 11,
        [EnumMember(Value = "CLOUD_AZURE")]
        CLOUDAZURE = 12,
        [EnumMember(Value = "CLOUD_GCP")]
        CLOUDGCP = 13,
        [EnumMember(Value = "CLOUD_NSXT")]
        CLOUDNSXT = 14,
    }
}
