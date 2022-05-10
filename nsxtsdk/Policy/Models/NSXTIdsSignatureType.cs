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
    public class NSXTIdsSignatureType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Mitre Attack details of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "mitre_attack")]
        public IList<NSXTMitreAttackType> MitreAttack { get; set; }
        /// <summary>
        /// Source-destination direction.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string? Direction { get; set; }
        /// <summary>
        /// Flag which tells whether the signature is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Protocol used in the packet analysis.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Class type of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "class_type")]
        public string? ClassType { get; set; }
        /// <summary>
        /// Flow established from server, from client etc.
        /// </summary>
        [JsonProperty(PropertyName = "flow")]
        public string? Flow { get; set; }
        /// <summary>
        /// Signature cvssv3 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv3")]
        public string? Cvssv3 { get; set; }
        /// <summary>
        /// Represents the cvss value of a Signature.
        /// The value is derived from cvssv3 or cvssv2 score.
        /// If cvssv3 exists, then this is the cvssv3 score, else
        /// it is the cvssv2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvss_score")]
        public string? CvssScore { get; set; }
        /// <summary>
        /// Vendor assigned classification tag.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public IList<string> Tag { get; set; }
        /// <summary>
        /// Signature action.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Family of the malware tracked in the signature.
        /// </summary>
        [JsonProperty(PropertyName = "malware_family")]
        public string? MalwareFamily { get; set; }
        /// <summary>
        /// CVE score
        /// </summary>
        [JsonProperty(PropertyName = "cves")]
        public IList<string> Cves { get; set; }
        /// <summary>
        /// Impact of Signature.
        /// </summary>
        [JsonProperty(PropertyName = "impact")]
        public string? Impact { get; set; }
        /// <summary>
        /// Signature's confidence score.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public string? Confidence { get; set; }
        /// <summary>
        /// Signature cvssv2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv2")]
        public string? Cvssv2 { get; set; }
        /// <summary>
        /// Represents the severity of the Signature.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string? Severity { get; set; }
        /// <summary>
        /// Represents revision of the Signature.
        /// </summary>
        [JsonProperty(PropertyName = "signature_revision")]
        public string? SignatureRevision { get; set; }
        /// <summary>
        /// Performance impact of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "performance_impact")]
        public string? PerformanceImpact { get; set; }
        /// <summary>
        /// Product affected by this signature.
        /// </summary>
        [JsonProperty(PropertyName = "product_affected")]
        public string? ProductAffected { get; set; }
        /// <summary>
        /// Signature name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Risk score of signature.
        /// </summary>
        [JsonProperty(PropertyName = "risk_score")]
        public string? RiskScore { get; set; }
        /// <summary>
        /// Signature vendor set severity of the signature rule.
        /// </summary>
        [JsonProperty(PropertyName = "signature_severity")]
        public string? SignatureSeverity { get; set; }
        /// <summary>
        /// Represents the internal categories a signature belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }
        /// <summary>
        /// List of mitre attack URLs pertaining to signature
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }
        /// <summary>
        /// Signature policy.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public IList<string> Policy { get; set; }
        /// <summary>
        /// Target of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "attack_target")]
        public string? AttackTarget { get; set; }
        /// <summary>
        /// Represents the Signature's id.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        public string? SignatureId { get; set; }
        /// <summary>
        /// Signature type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
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
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIdsSignatureCvssEnumType? Cvss { get; set; }
    }
}
