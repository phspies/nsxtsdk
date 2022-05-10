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
    /// Identity (Directory) group
    /// </summary>
    [NSXTProperty(Description: @"Identity (Directory) group")]
    public class NSXTIdentityGroupInfoType 
    {
        /// <summary>
        /// Each LDAP object is uniquely identified by its distinguished name (DN).
        /// A DN is a sequence of relative distinguished names (RDN) connected by commas.
        /// e.g. CN=Larry Cole,CN=admin,DC=corp,DC=acme,DC=com.
        /// A valid fully qualified distinguished name should be provided to include specific groups else
        /// the create / update realization of the Group containing an invalid/ partial DN will fail.
        /// This value is valid only if it matches to exactly 1 LDAP object on the LDAP server.
        /// </summary>
        [JsonProperty(PropertyName = "distinguished_name", Required = Required.AllowNull)]
        public string DistinguishedName { get; set; }
        /// <summary>
        /// This is the base distinguished name for the domain where this particular group
        /// resides. (e.g. dc=example,dc=com)
        /// Each active directory domain has a domain naming context
        /// (NC), which contains domain-specific data. The root of
        /// this naming context is represented by a domain's
        /// distinguished name (DN) and is typically referred to as
        /// the NC head.
        /// </summary>
        [JsonProperty(PropertyName = "domain_base_distinguished_name", Required = Required.AllowNull)]
        public string DomainBaseDistinguishedName { get; set; }
        /// <summary>
        /// A security identifier (SID) is a unique value of variable length
        /// used to identify a trustee. A SID consists of the following components:
        /// The revision level of the SID structure;
        /// A 48-bit identifier authority value that identifies the
        /// authority that issued the SID;
        /// A variable number of subauthority or relative identifier
        /// (RID) values that uniquely identify the trustee relative
        /// to the authority that issued the SID.
        /// This field is only populated for Microsoft Active Directory identity store.
        /// </summary>
        [JsonProperty(PropertyName = "sid")]
        public string? Sid { get; set; }
    }
}
