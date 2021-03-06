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
    public class NSXTServiceInsertionRuleType : NSXTDSRuleType
    {
        /// <summary>
        /// List of the services. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTServiceInsertionServiceType> Services { get; set; }
        /// <summary>
        /// A rule can be redirected to ServiceInstance, InstanceEndpoint for North/South Traffic. A rule can be redirected to
        /// ServiceChain for East/West Traffic. For REDIRECT action, redirect_tos is mandatory. For DO_NOT_REDIRECT action,
        /// redirect_tos is optional.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_tos")]
        public IList<NSXTResourceReferenceType> RedirectTos { get; set; }
        /// <summary>
        /// ID of the section to which this rule belongs.
        /// </summary>
        [JsonProperty(PropertyName = "section_id")]
        public string? SectionId { get; set; }
    }
}
