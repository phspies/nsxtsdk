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
    public class NSXTNSProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Reference to the encapsulating object of attributes/sub-attributes for
        /// NSProfile.
        /// </summary>
        [JsonProperty(PropertyName = "nsprofile_attribute", Required = Required.AllowNull)]
        public IList<NSXTNSAttributesType> NsprofileAttribute { get; set; }
        /// <summary>
        /// If set to false, the NSProfile has some app ids which
        /// are unsupported. Those were allowed to be added in
        /// previous releases but in testing in later phases
        /// found that those app ids could not be detected.
        /// </summary>
        [JsonProperty(PropertyName = "is_valid")]
        public bool? IsValid { get; set; }
    }
}
