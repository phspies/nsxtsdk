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
    /// Advanced load balancer HardwareSecurityModule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HardwareSecurityModule object")]
    public class NSXTALBHardwareSecurityModuleType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rfs")]
        public NSXTALBHSMThalesRFSType Rfs { get; set; }
        /// <summary>
        /// HSM type to use.
        /// Enum options - HSM_TYPE_THALES_NETHSM,
        /// HSM_TYPE_SAFENET_LUNA, HSM_TYPE_AWS_CLOUDHSM.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhardwareSecurityModuleTypeEnumType Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sluna")]
        public NSXTALBHSMSafenetLunaType Sluna { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cloudhsm")]
        public NSXTALBHSMAwsCloudHsmType Cloudhsm { get; set; }
        /// <summary>
        /// Thales netHSM specific configuration.
        /// </summary>
        [JsonProperty(PropertyName = "nethsm")]
        public IList<NSXTALBHSMThalesNetHsmType> Nethsm { get; set; }
    }
}
