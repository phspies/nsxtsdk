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
    public class NSXTIdsSignatureType : NSXTPolicyConfigResourceType
    {
        public NSXTIdsSignatureType()
        {
        }
        /// <summary>
        /// Mitre Attack details of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "mitre_attack")]
        [NSXTProperty(IsRequired: false, Description: @"Mitre Attack details of Signature.")]
        public IList<NSXTMitreAttackType> MitreAttack { get; set; }
        /// <summary>
        /// Source-destination direction.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [NSXTProperty(IsRequired: false, Description: @"Source-destination direction.")]
        public string? Direction { get; set; }
        /// <summary>
        /// Flag which tells whether the signature is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        [NSXTProperty(IsRequired: false, Description: @"Flag which tells whether the signature is enabled or not.")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Protocol used in the packet analysis.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"Protocol used in the packet analysis.")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Class type of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "class_type")]
        [NSXTProperty(IsRequired: false, Description: @"Class type of Signature.")]
        public string? ClassType { get; set; }
        /// <summary>
        /// Flow established from server, from client etc.
        /// </summary>
        [JsonProperty(PropertyName = "flow")]
        [NSXTProperty(IsRequired: false, Description: @"Flow established from server, from client etc.")]
        public string? Flow { get; set; }
        /// <summary>
        /// Signature cvssv3 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv3")]
        [NSXTProperty(IsRequired: false, Description: @"Signature cvssv3 score.")]
        public string? Cvssv3 { get; set; }
        /// <summary>
        /// Represents the cvss value of a Signature.
        /// The value is derived from cvssv3 or cvssv2 score.
        /// If cvssv3 exists, then this is the cvssv3 score, else
        /// it is the cvssv2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvss_score")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the cvss value of a Signature.The value is derived from cvssv3 or cvssv2 score.If cvssv3 exists, then this is the cvssv3 score, elseit is the cvssv2 score.")]
        public string? CvssScore { get; set; }
        /// <summary>
        /// Vendor assigned classification tag.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        [NSXTProperty(IsRequired: false, Description: @"Vendor assigned classification tag.")]
        public IList<string> Tag { get; set; }
        /// <summary>
        /// Signature action.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"Signature action.")]
        public string? Action { get; set; }
        /// <summary>
        /// Family of the malware tracked in the signature.
        /// </summary>
        [JsonProperty(PropertyName = "malware_family")]
        [NSXTProperty(IsRequired: false, Description: @"Family of the malware tracked in the signature.")]
        public string? MalwareFamily { get; set; }
        /// <summary>
        /// CVE score
        /// </summary>
        [JsonProperty(PropertyName = "cves")]
        [NSXTProperty(IsRequired: false, Description: @"CVE score")]
        public IList<string> Cves { get; set; }
        /// <summary>
        /// Impact of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "impact")]
        [NSXTProperty(IsRequired: false, Description: @"Impact of Signature.")]
        public string? Impact { get; set; }
        /// <summary>
        /// Signature's confidence score.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        [NSXTProperty(IsRequired: false, Description: @"Signature&apos;s confidence score.")]
        public string? Confidence { get; set; }
        /// <summary>
        /// Signature cvssv2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv2")]
        [NSXTProperty(IsRequired: false, Description: @"Signature cvssv2 score.")]
        public string? Cvssv2 { get; set; }
        /// <summary>
        /// Represents the severity of the Signature.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the severity of the Signature.")]
        public string? Severity { get; set; }
        /// <summary>
        /// Represents revision of the Signature.
        /// </summary>
        [JsonProperty(PropertyName = "signature_revision")]
        [NSXTProperty(IsRequired: false, Description: @"Represents revision of the Signature.")]
        public string? SignatureRevision { get; set; }
        /// <summary>
        /// Performance impact of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "performance_impact")]
        [NSXTProperty(IsRequired: false, Description: @"Performance impact of the signature.")]
        public string? PerformanceImpact { get; set; }
        /// <summary>
        /// Product affected by this signature.
        /// </summary>
        [JsonProperty(PropertyName = "product_affected")]
        [NSXTProperty(IsRequired: false, Description: @"Product affected by this signature.")]
        public string? ProductAffected { get; set; }
        /// <summary>
        /// Signature name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        [NSXTProperty(IsRequired: false, Description: @"Signature name.")]
        public string? Name { get; set; }
        /// <summary>
        /// Risk score of signature.
        /// </summary>
        [JsonProperty(PropertyName = "risk_score")]
        [NSXTProperty(IsRequired: false, Description: @"Risk score of signature.")]
        public string? RiskScore { get; set; }
        /// <summary>
        /// Signature vendor set severity of the signature rule.
        /// </summary>
        [JsonProperty(PropertyName = "signature_severity")]
        [NSXTProperty(IsRequired: false, Description: @"Signature vendor set severity of the signature rule.")]
        public string? SignatureSeverity { get; set; }
        /// <summary>
        /// Represents the internal categories a signature belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the internal categories a signature belongs to.")]
        public IList<string> Categories { get; set; }
        /// <summary>
        /// List of mitre attack URLs pertaining to signature
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        [NSXTProperty(IsRequired: false, Description: @"List of mitre attack URLs pertaining to signature")]
        public IList<string> Urls { get; set; }
        /// <summary>
        /// Signature policy.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        [NSXTProperty(IsRequired: false, Description: @"Signature policy.")]
        public IList<string> Policy { get; set; }
        /// <summary>
        /// Target of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "attack_target")]
        [NSXTProperty(IsRequired: false, Description: @"Target of the signature.")]
        public string? AttackTarget { get; set; }
        /// <summary>
        /// Represents the Signature's id.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the Signature&apos;s id.")]
        public string? SignatureId { get; set; }
        /// <summary>
        /// Signature type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Signature type.")]
        public IList<string> Type { get; set; }
        /// <summary>
        /// Represents the cvss value of a Signature.
        /// The value is derived from cvssv3 or cvssv2 score.
        /// NONE     means cvssv3/cvssv2 score as 0.0
        /// LOW      means cvssv3/cvssv2 score as 0.1-3.9
        /// MEDIUM   means cvssv3/cvssv2 score as 4.0-6.9
        /// HIGH     means cvssv3/cvssv2 score as 7.0-8.9
        /// CRITICAL means cvssv3/cvssv2 score as 9.0-10.0
        /// </summary>
        [JsonProperty(PropertyName = "cvss")]
        [NSXTProperty(IsRequired: false, Description: @"Represents the cvss value of a Signature.The value is derived from cvssv3 or cvssv2 score.NONE     means cvssv3/cvssv2 score as 0.0LOW      means cvssv3/cvssv2 score as 0.1-3.9MEDIUM   means cvssv3/cvssv2 score as 4.0-6.9HIGH     means cvssv3/cvssv2 score as 7.0-8.9CRITICAL means cvssv3/cvssv2 score as 9.0-10.0")]
        public NSXTIdsSignatureCvssEnumType? Cvss { get; set; }
    }
}
