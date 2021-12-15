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
    public class NSXTAviConnectionInfoType : NSXTEnforcementPointConnectionInfoType
    {
        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        [NSXTProperty(IsRequired: false, Description: @"Username.")]
        public string? Username { get; set; }
        /// <summary>
        /// Avi supports API versioning for backward compatibility with automation scripts written for an object model older than
        /// the current one.
        /// Such scripts need not be updated to keep up with object model changes
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Avi supports API versioning for backward compatibility with automation scripts written for an object model older than the current one.Such scripts need not be updated to keep up with object model changes")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Version { get; set; }
        /// <summary>
        /// A tenant is an isolated instance of Avi Controller.
        /// Each Avi user account is associated with one or more tenants.
        /// The tenant associated with a user account defines the resources that user can access within Avi Vantage.
        /// When a user logs in, Avi restricts their access to only those resources that are in the same tenant
        /// </summary>
        [JsonProperty(PropertyName = "tenant", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"A tenant is an isolated instance of Avi Controller.Each Avi user account is associated with one or more tenants.The tenant associated with a user account defines the resources that user can access within Avi Vantage.When a user logs in, Avi restricts their access to only those resources that are in the same tenant")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Tenant { get; set; }
        /// <summary>
        /// Thumbprint of EnforcementPoint in the form of a SHA-256 hash represented in lower case HEX.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        [NSXTProperty(IsRequired: false, Description: @"Thumbprint of EnforcementPoint in the form of a SHA-256 hash represented in lower case HEX.")]
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        [NSXTProperty(IsRequired: false, Description: @"Password.")]
        public string? Password { get; set; }
        /// <summary>
        /// Clouds are containers for the environment that Avi Vantage is installed or operating within.
        /// During initial setup of Vantage, a default cloud, named Default-Cloud, is created.
        /// This is where the first Controller is deployed, into Default-Cloud. Additional clouds may be added,
        /// containing SEs and virtual services.
        /// </summary>
        [JsonProperty(PropertyName = "cloud", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Clouds are containers for the environment that Avi Vantage is installed or operating within.During initial setup of Vantage, a default cloud, named Default-Cloud, is created.This is where the first Controller is deployed, into Default-Cloud. Additional clouds may be added,containing SEs and virtual services.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Cloud { get; set; }
    }
}
