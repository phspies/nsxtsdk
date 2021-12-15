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
        [NSXTProperty(IsRequired: false, Description: @"The default NSServiceGroups are created in the system by default. TheseNSServiceGroups can&apos;t be modified/deleted")]
        public bool? DefaultService { get; set; }
        /// <summary>
        /// Type of the NSServiceGroup
        /// </summary>
        [JsonProperty(PropertyName = "service_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of the NSServiceGroup")]
        public NSXTNsserviceGroupServiceTypeEnumType? ServiceType { get; set; }
        /// <summary>
        /// List of NSService resources that can be added as members
        /// to an NSServiceGroup.
        /// </summary>
        [JsonProperty(PropertyName = "members", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"List of NSService resources that can be added as membersto an NSServiceGroup.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTResourceReferenceType> Members { get; set; }
    }
}