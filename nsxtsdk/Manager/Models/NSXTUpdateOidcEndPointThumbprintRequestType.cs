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
    public class NSXTUpdateOidcEndPointThumbprintRequestType : NSXTManagedResourceType
    {
        /// <summary>
        /// URI where to download the meta-data of the OIDC end-point.
        /// </summary>
        [JsonProperty(PropertyName = "oidc_uri", Required = Required.AllowNull)]
        public string OidcUri { get; set; }
        /// <summary>
        /// Thumbprint of the OIDC URI to make an SSL connection.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
    }
}
