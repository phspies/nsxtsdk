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
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("NestedServiceServiceEntry", typeof(NSXTNestedServiceServiceEntryType))]
    [JsonInheritanceAttribute("EtherTypeServiceEntry", typeof(NSXTEtherTypeServiceEntryType))]
    [JsonInheritanceAttribute("ICMPTypeServiceEntry", typeof(NSXTICMPTypeServiceEntryType))]
    [JsonInheritanceAttribute("ALGTypeServiceEntry", typeof(NSXTALGTypeServiceEntryType))]
    [JsonInheritanceAttribute("IPProtocolServiceEntry", typeof(NSXTIPProtocolServiceEntryType))]
    [JsonInheritanceAttribute("IGMPTypeServiceEntry", typeof(NSXTIGMPTypeServiceEntryType))]
    [JsonInheritanceAttribute("L4PortSetServiceEntry", typeof(NSXTL4PortSetServiceEntryType))]
    [NSXTProperty(Description: @"")]
    public class NSXTServiceEntryType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServiceEntryResourceTypeEnumType ResourceType { get; set; }
    }
}
