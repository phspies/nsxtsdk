// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSubjectPublicKeyHashType 
    {
        /// <summary>
        /// List of SHA256 hashes of the Public Key of the revoked certificates with the specified subject.
        /// </summary>
        public IList<string> PublicKeySha256Hashes { get; set; }
        /// <summary>
        /// Subject Distinguished Name of the revoked certificates.
        /// </summary>
        public string? Subject { get; set; }
    }
}
