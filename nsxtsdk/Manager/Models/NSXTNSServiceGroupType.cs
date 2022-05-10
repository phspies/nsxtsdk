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
    public class NSXTNSServiceGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// The default NSServiceGroups are created in the system by default. These
        /// NSServiceGroups can't be modified/deleted
        /// </summary>
        [JsonProperty(PropertyName = "default_service")]
        public bool? DefaultService { get; set; }
        /// <summary>
        /// Type of the NSServiceGroup
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsserviceGroupServiceTypeEnumType? ServiceType { get; set; }
        /// <summary>
        /// List of NSService resources that can be added as members
        /// to an NSServiceGroup.
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        public IList<NSXTResourceReferenceType> Members { get; set; }
    }
}
