// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using nsxtsdk;
using nsxtsdk.Models;
using nsxtsdk.ManagerModels;

namespace nsxtapi.ManagerModules
{
    public class CoreDumpModule
    {
        RestClient restClient;
        JsonSerializerSettings defaultSerializationSettings;
        public CoreDumpModule(RestClient Client, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = Client;
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public void CopyCoreDumpToRemoteFileCopyToRemoteFile(string FileName, NSXTCopyToRemoteFilePropertiesType CopyToRemoteFileProperties)
        {
            if (FileName == null) { throw new System.ArgumentNullException("FileName cannot be null"); }
            if (CopyToRemoteFileProperties == null) { throw new System.ArgumentNullException("CopyToRemoteFileProperties cannot be null"); }
            
            StringBuilder CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL = new StringBuilder("/node/core-dumps/{file-name}?action=copy_to_remote_file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.POST
            };
            request.AddHeader("Content-type", "application/json");
            CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL.Replace("{file-name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(JsonConvert.SerializeObject(CopyToRemoteFileProperties, defaultSerializationSettings));
            request.Resource = CopyCoreDumpToRemoteFileCopyToRemoteFileServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        [NSXTProperty(Description: @"")]
        public NSXTFilePropertiesListResultType ListCoreDumps()
        {
            NSXTFilePropertiesListResultType returnValue = default(NSXTFilePropertiesListResultType);
            StringBuilder ListCoreDumpsServiceURL = new StringBuilder("/node/core-dumps");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };
            request.AddHeader("Content-type", "application/json");
            request.Resource = ListCoreDumpsServiceURL.ToString();
            var response = restClient.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
			{
                returnValue = JsonConvert.DeserializeObject<NSXTFilePropertiesListResultType>(response.Content, defaultSerializationSettings);
			}
            else
            {
                throw new NSXTException(response.Content, response.StatusCode.ToString());
            }
            return returnValue;
        }
    }
}
