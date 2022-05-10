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
    [NSXTProperty(Description: @"")]
    public class NSXTALBCertificateManagementProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Placeholder for description of property script_params of
        /// obj type CertificateManagementProfile field type str  type
        /// array.
        /// </summary>
        [JsonProperty(PropertyName = "script_params")]
        public IList<NSXTALBCustomParamsType> ScriptParams { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
