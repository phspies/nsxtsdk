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
    public class NSXTUpdatePrincipalIdentityCertificateRequestType : NSXTManagedResourceType
    {
        /// <summary>
        /// Unique ID of the principal.
        /// </summary>
        [JsonProperty(PropertyName = "principal_identity_id", Required = Required.AllowNull)]
        public string PrincipalIdentityId { get; set; }
        /// <summary>
        /// Id of the stored certificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_id", Required = Required.AllowNull)]
        public string CertificateId { get; set; }
    }
}
