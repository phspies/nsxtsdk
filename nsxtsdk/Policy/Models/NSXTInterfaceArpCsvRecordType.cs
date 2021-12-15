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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTInterfaceArpCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// The IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The IP address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Ip { get; set; }
        /// <summary>
        /// The MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The MAC address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string MacAddress { get; set; }
    }
}
