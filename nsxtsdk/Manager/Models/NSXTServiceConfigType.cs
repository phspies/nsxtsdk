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
    public class NSXTServiceConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// The list of entities that the configurations should be applied to.
        /// This can either be a NSGroup or any other entity like TransportNode, LogicalPorts etc.
        /// </summary>
        [JsonProperty(PropertyName = "applied_to")]
        [NSXTProperty(IsRequired: false, Description: @"The list of entities that the configurations should be applied to.This can either be a NSGroup or any other entity like TransportNode, LogicalPorts etc.")]
        public IList<NSXTResourceReferenceType> AppliedTo { get; set; }
        /// <summary>
        /// Every ServiceConfig has a priority based upon its precedence value. Lower the value
        /// of precedence, higher will be its priority. If user doesnt specify the precedence,
        /// it is generated automatically by system. The precedence is generated based upon the
        /// type of profile used in ServiceConfig. Precedence are auto-generated in decreasing
        /// order with difference of 100. Automatically generated precedence value will be 100
        /// less than the current minimum value of precedence of ServiceConfig of a given profile
        /// type in system.There cannot be duplicate precedence for ServiceConfig of same profile
        /// type.
        /// </summary>
        [JsonProperty(PropertyName = "precedence")]
        [NSXTProperty(IsRequired: false, Description: @"Every ServiceConfig has a priority based upon its precedence value. Lower the valueof precedence, higher will be its priority. If user doesnt specify the precedence,it is generated automatically by system. The precedence is generated based upon thetype of profile used in ServiceConfig. Precedence are auto-generated in decreasingorder with difference of 100. Automatically generated precedence value will be 100less than the current minimum value of precedence of ServiceConfig of a given profiletype in system.There cannot be duplicate precedence for ServiceConfig of same profiletype.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4294967295)]
        public long? Precedence { get; set; }
        /// <summary>
        /// These are the NSX Profiles which will be added to service config, which
        /// will be applied to entities/groups provided to applied_to field of service config.
        /// </summary>
        [JsonProperty(PropertyName = "profiles", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"These are the NSX Profiles which will be added to service config, whichwill be applied to entities/groups provided to applied_to field of service config.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTNSXProfileReferenceType> Profiles { get; set; }
    }
}
