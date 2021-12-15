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
    /// OSPF Interface configuration.
    /// </summary>
    [NSXTProperty(Description: @"OSPF Interface configuration.")]
    public class NSXTPolicyInterfaceOspfConfigType 
    {
        /// <summary>
        /// Specifies the number of seconds that router must wait before it declares
        /// a OSPF neighbor router down because it has not received OSPF hello packet.
        /// OSPF dead interval should be minimum 3 times greater than the hello interval
        /// </summary>
        [JsonProperty(PropertyName = "dead_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the number of seconds that router must wait before it declaresa OSPF neighbor router down because it has not received OSPF hello packet.OSPF dead interval should be minimum 3 times greater than the hello interval")]
        //[System.ComponentModel.DataAnnotations.MinLength(3)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [NSXTDefaultProperty(Default: "")]
        public long? DeadInterval { get; set; }
        /// <summary>
        /// Attache Tier0 Interface to specified OSPF Area.
        /// all peers.
        /// </summary>
        [JsonProperty(PropertyName = "ospf_area", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Attache Tier0 Interface to specified OSPF Area.all peers.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string OspfArea { get; set; }
        /// <summary>
        /// Specifies the interval between the hello packets that OSPF sends on this interface.
        /// OSPF hello interval should be less than the dead interval
        /// </summary>
        [JsonProperty(PropertyName = "hello_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the interval between the hello packets that OSPF sends on this interface.OSPF hello interval should be less than the dead interval")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(21845)]
        [NSXTDefaultProperty(Default: "")]
        public long? HelloInterval { get; set; }
        /// <summary>
        /// Enable/Disable OSPF to register for BFD event. Use FALSE to disable BFD.
        /// </summary>
        [JsonProperty(PropertyName = "enable_bfd")]
        [NSXTProperty(IsRequired: false, Description: @"Enable/Disable OSPF to register for BFD event. Use FALSE to disable BFD.")]
        public bool? EnableBfd { get; set; }
        /// <summary>
        /// enable/disable OSPF on the interface. If enabled flag not specified, defailt is disable OSPF.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"enable/disable OSPF on the interface. If enabled flag not specified, defailt is disable OSPF.")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Configure OSPF networkt type, default is BROADCAST network type
        /// </summary>
        [JsonProperty(PropertyName = "network_type")]
        [NSXTProperty(IsRequired: false, Description: @"Configure OSPF networkt type, default is BROADCAST network type")]
        [NSXTDefaultProperty(Default: "BROADCAST")]
        public NSXTPolicyInterfaceOspfConfigNetworkTypeEnumType? NetworkType { get; set; }
        /// <summary>
        /// This filed is valid only if enable_bfd is set to TRUE.
        /// If enable_bfd flag is set to TRUE, this profile will be applied to all OSPF peers in this interface.
        /// If this field is empty, bfd_path will refer to Tier-0 global BFD profile.
        /// </summary>
        [JsonProperty(PropertyName = "bfd_path")]
        [NSXTProperty(IsRequired: false, Description: @"This filed is valid only if enable_bfd is set to TRUE.If enable_bfd flag is set to TRUE, this profile will be applied to all OSPF peers in this interface.If this field is empty, bfd_path will refer to Tier-0 global BFD profile.")]
        public string? BfdPath { get; set; }
    }
}
