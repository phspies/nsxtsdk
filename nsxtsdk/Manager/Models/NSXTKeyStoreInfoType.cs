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
    /// Key Store information about the url alias or datasource.
    /// </summary>
    [NSXTProperty(Description: @"Key Store information about the url alias or datasource.")]
    public class NSXTKeyStoreInfoType 
    {
        public NSXTKeyStoreInfoType()
        {
        }
        /// <summary>
        /// A location of the keystor file which stores private key and identity certificates that will be presented to both parties
        /// (server or client) for verification.
        /// </summary>
        [JsonProperty(PropertyName = "keystore")]
        [NSXTProperty(IsRequired: false, Description: @"A location of the keystor file which stores private key and identity certificates that will be presented to both parties (server or client) for verification.")]
        public string? Keystore { get; set; }
        /// <summary>
        /// Its an alias specified when an entity is added to the keystore.
        /// </summary>
        [JsonProperty(PropertyName = "keystore_alias")]
        [NSXTProperty(IsRequired: false, Description: @"Its an alias specified when an entity is added to the keystore.")]
        public string? KeystoreAlias { get; set; }
        /// <summary>
        /// A location of the trust store file which stores the certificate from CA that verify the certificate presented by the
        /// server in SSL connection.
        /// </summary>
        [JsonProperty(PropertyName = "truststore")]
        [NSXTProperty(IsRequired: false, Description: @"A location of the trust store file which stores the certificate from CA that verify the certificate presented by the server in SSL connection.")]
        public string? Truststore { get; set; }
        /// <summary>
        /// A location of the key store pass phrase file.
        /// </summary>
        [JsonProperty(PropertyName = "keystore_phrase")]
        [NSXTProperty(IsRequired: false, Description: @"A location of the key store pass phrase file.")]
        public string? KeystorePhrase { get; set; }
    }
}
