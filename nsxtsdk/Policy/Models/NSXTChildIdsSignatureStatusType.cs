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
    public class NSXTChildIdsSignatureStatusType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// Contains the IdsSignatureStatus object
        /// </summary>
        [JsonProperty(PropertyName = "IdsSignatureStatus", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Contains the IdsSignatureStatus object")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIdsSignatureStatusType IdsSignatureStatus { get; set; }
    }
}
