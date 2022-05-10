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
    public class NSXTIDSSignatureDetailType 
    {
        /// <summary>
        /// Product affected by the signature.
        /// </summary>
        [JsonProperty(PropertyName = "affected_product")]
        public string? AffectedProduct { get; set; }
        /// <summary>
        /// Source-destination direction.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        public string? Direction { get; set; }
        /// <summary>
        /// Protocol used in the packet analysis.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public string? Protocol { get; set; }
        /// <summary>
        /// Class type of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "class_type")]
        public string? ClassType { get; set; }
        /// <summary>
        /// Signature enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Packet analysis action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string? Action { get; set; }
        /// <summary>
        /// Vendor assigned classification tag.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public IList<string> Tag { get; set; }
        /// <summary>
        /// Family of the malware tracked in the signature.
        /// </summary>
        [JsonProperty(PropertyName = "malware_family")]
        public string? MalwareFamily { get; set; }
        /// <summary>
        /// Name of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// VMware defined signature category.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public IList<string> Category { get; set; }
        /// <summary>
        /// Signature CVSSV3 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv3")]
        public string? Cvssv3 { get; set; }
        /// <summary>
        /// Signature CVSSV2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvssv2")]
        public string? Cvssv2 { get; set; }
        /// <summary>
        /// VMware defined signature severity.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string? Severity { get; set; }
        /// <summary>
        /// The revision of the signature
        /// </summary>
        [JsonProperty(PropertyName = "signature_revision")]
        public long? SignatureRevision { get; set; }
        /// <summary>
        /// Performance impact of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "performance_impact")]
        public string? PerformanceImpact { get; set; }
        /// <summary>
        /// Flow established from server, from client etc.
        /// </summary>
        [JsonProperty(PropertyName = "flow")]
        public string? Flow { get; set; }
        /// <summary>
        /// Signature vendor set severity of the signature rule.
        /// </summary>
        [JsonProperty(PropertyName = "signature_severity")]
        public string? SignatureSeverity { get; set; }
        /// <summary>
        /// List of mitre attack URLs pertaining to signature.
        /// </summary>
        [JsonProperty(PropertyName = "urls")]
        public IList<string> Urls { get; set; }
        /// <summary>
        /// Signature policy.
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public IList<string> Policy { get; set; }
        /// <summary>
        /// Target of the attack tracked in the signature.
        /// </summary>
        [JsonProperty(PropertyName = "attack_target")]
        public string? AttackTarget { get; set; }
        /// <summary>
        /// Unique ID of the signature rule.
        /// </summary>
        [JsonProperty(PropertyName = "signature_id")]
        public long? SignatureId { get; set; }
        /// <summary>
        /// CVE of the signature.
        /// </summary>
        [JsonProperty(PropertyName = "cves")]
        public IList<string> Cves { get; set; }
        /// <summary>
        /// Signature type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public IList<string> Type { get; set; }
        /// <summary>
        /// Represents the cvss value of a Signature.
        /// The value is derived from cvssv3 or cvssv2 score.
        /// If cvssv3 exists, then this is the cvssv3 score, else
        /// it is the cvssv2 score.
        /// </summary>
        [JsonProperty(PropertyName = "cvss")]
        public string? Cvss { get; set; }
        /// <summary>
        /// IDSSignatureDetail resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
    }
}
