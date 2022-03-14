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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTAviConnectionInfoType : NSXTEnforcementPointConnectionInfoType
    {
        /// <summary>
        /// Username.
        /// </summary>
        public string? Username { get; set; }
        /// <summary>
        /// Avi supports API versioning for backward compatibility with automation scripts written for an object model older than
        /// the current one.
        /// Such scripts need not be updated to keep up with object model changes
        /// This is a deprecated property. The version is now auto
        /// populated from property file and its value can be read using APIs
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// Expiry time of the token will be set by LCM at the time of Enforcement Point Creation.
        /// </summary>
        public string? ExpiresAt { get; set; }
        /// <summary>
        /// Thumbprint of EnforcementPoint in the form of a SHA-256 hash represented in lower case HEX.
        /// </summary>
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Managed by used when on-borading workflow created by LCM/VCF.
        /// </summary>
        public string? ManagedBy { get; set; }
        /// <summary>
        /// Password or Token for Avi Controller.
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// Clouds are containers for the environment that Avi Vantage is installed or operating within.
        /// During initial setup of Vantage, a default cloud, named Default-Cloud, is created.
        /// This is where the first Controller is deployed, into Default-Cloud. Additional clouds may be added,
        /// containing SEs and virtual services.
        /// This is a deprecated property.
        /// Cloud has been renamed to cloud_name and it will added from specific ALB entity.
        /// </summary>
        public string? Cloud { get; set; }
        /// <summary>
        /// A tenant is an isolated instance of Avi Controller.
        /// Each Avi user account is associated with one or more tenants.
        /// The tenant associated with a user account defines the resources that user can access within Avi Vantage.
        /// When a user logs in, Avi restricts their access to only those resources that are in the same tenant
        /// </summary>
        [JsonProperty(PropertyName = "tenant", Required = Required.AllowNull)]
        public string Tenant { get; set; }
    }
}
