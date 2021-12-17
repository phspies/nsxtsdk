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
    public class NSXTTransportInfoType 
    {
        public NSXTTransportInfoType()
        {
        }
        /// <summary>
        /// Source port
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        [NSXTProperty(IsRequired: false, Description: @"Source port")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? SrcPort { get; set; }
        /// <summary>
        /// Protocol type over IP layer
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"Protocol type over IP layer")]
        public NSXTTransportInfoProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Destination port
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        [NSXTProperty(IsRequired: false, Description: @"Destination port")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? DstPort { get; set; }
    }
}
