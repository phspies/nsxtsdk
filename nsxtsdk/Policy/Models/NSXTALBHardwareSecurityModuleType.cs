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
    /// Advanced load balancer HardwareSecurityModule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HardwareSecurityModule object")]
    public class NSXTALBHardwareSecurityModuleType 
    {
        /// <summary>
        /// Thales Remote File Server (RFS), used for the netHSMs,
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "rfs")]
        [NSXTProperty(IsRequired: false, Description: @"Thales Remote File Server (RFS), used for the netHSMs,configuration.")]
        public NSXTALBHSMThalesRFSType Rfs { get; set; }
        /// <summary>
        /// HSM type to use.
        /// Enum options - HSM_TYPE_THALES_NETHSM,
        /// HSM_TYPE_SAFENET_LUNA, HSM_TYPE_AWS_CLOUDHSM.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"HSM type to use.Enum options - HSM_TYPE_THALES_NETHSM,HSM_TYPE_SAFENET_LUNA, HSM_TYPE_AWS_CLOUDHSM.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTAlbhardwareSecurityModuleTypeEnumType Type { get; set; }
        /// <summary>
        /// Safenet/Gemalto Luna/Gem specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "sluna")]
        [NSXTProperty(IsRequired: false, Description: @"Safenet/Gemalto Luna/Gem specific configuration.")]
        public NSXTALBHSMSafenetLunaType Sluna { get; set; }
        /// <summary>
        /// AWS CloudHSM specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "cloudhsm")]
        [NSXTProperty(IsRequired: false, Description: @"AWS CloudHSM specific configuration.")]
        public NSXTALBHSMAwsCloudHsmType Cloudhsm { get; set; }
        /// <summary>
        /// Thales netHSM specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "nethsm")]
        [NSXTProperty(IsRequired: false, Description: @"Thales netHSM specific configuration.")]
        public IList<NSXTALBHSMThalesNetHsmType> Nethsm { get; set; }
    }
}