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
    public class NSXTLicenseType : NSXTResourceType
    {
        /// <summary>
        /// semicolon delimited feature list
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public string? Features { get; set; }
        /// <summary>
        /// license edition
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// product version
        /// </summary>
        [JsonProperty(PropertyName = "product_version")]
        public string? ProductVersion { get; set; }
        /// <summary>
        /// date that license expires
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public long? Expiry { get; set; }
        /// <summary>
        /// true for evalution license
        /// </summary>
        [JsonProperty(PropertyName = "is_eval")]
        public bool? IsEval { get; set; }
        /// <summary>
        /// multi-hypervisor support
        /// </summary>
        [JsonProperty(PropertyName = "is_mh")]
        public bool? IsMh { get; set; }
        /// <summary>
        /// license key
        /// </summary>
        [JsonProperty(PropertyName = "license_key")]
        public string? LicenseKey { get; set; }
        /// <summary>
        /// whether the license has expired
        /// </summary>
        [JsonProperty(PropertyName = "is_expired")]
        public bool? IsExpired { get; set; }
        /// <summary>
        /// product name
        /// </summary>
        [JsonProperty(PropertyName = "product_name")]
        public string? ProductName { get; set; }
        /// <summary>
        /// License metrics specifying the capacity type of license key.
        /// Types are:
        /// - VM
        /// - CPU
        /// - USER(Concurrent User)
        /// - CORE
        /// - HOST
        /// </summary>
        [JsonProperty(PropertyName = "capacity_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLicenseCapacityTypeEnumType? CapacityType { get; set; }
        /// <summary>
        /// license capacity; 0 for unlimited
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public long? Quantity { get; set; }
    }
}
