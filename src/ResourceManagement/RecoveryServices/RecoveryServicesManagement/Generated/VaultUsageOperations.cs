// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices;
using Microsoft.Azure.Management.RecoveryServices.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices
{
    /// <summary>
    /// Definition of vault operations for the Recovery Services extension.
    /// </summary>
    internal partial class VaultUsageOperations : IServiceOperations<RecoveryServicesManagementClient>, IVaultUsageOperations
    {
        /// <summary>
        /// Initializes a new instance of the VaultUsageOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal VaultUsageOperations(RecoveryServicesManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.RecoveryServicesManagementClient.
        /// </summary>
        public RecoveryServicesManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get the Vault Usage.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the (resource group?) cloud service
        /// containing the vault collection.
        /// </param>
        /// <param name='vaultName'>
        /// Required. The name of the vault to get usage.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for Vault usage.
        /// </returns>
        public async Task<VaultUsageListResponse> ListAsync(string resourceGroupName, string vaultName, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException("vaultName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("vaultName", vaultName);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(vaultName);
            url = url + "/usages";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-11-10");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                httpRequest.Headers.Add("x-ms-version", "2015-01-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    VaultUsageListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new VaultUsageListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    Usage usageInstance = new Usage();
                                    result.Value.Add(usageInstance);
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        Name nameInstance = new Name();
                                        usageInstance.Name = nameInstance;
                                        
                                        JToken valueValue2 = nameValue["value"];
                                        if (valueValue2 != null && valueValue2.Type != JTokenType.Null)
                                        {
                                            string valueInstance = ((string)valueValue2);
                                            nameInstance.Value = valueInstance;
                                        }
                                        
                                        JToken localizedValueValue = nameValue["localizedValue"];
                                        if (localizedValueValue != null && localizedValueValue.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance = ((string)localizedValueValue);
                                            nameInstance.LocalizedValue = localizedValueInstance;
                                        }
                                    }
                                    
                                    JToken unitValue = valueValue["unit"];
                                    if (unitValue != null && unitValue.Type != JTokenType.Null)
                                    {
                                        string unitInstance = ((string)unitValue);
                                        usageInstance.Unit = unitInstance;
                                    }
                                    
                                    JToken currentValueValue = valueValue["currentValue"];
                                    if (currentValueValue != null && currentValueValue.Type != JTokenType.Null)
                                    {
                                        long currentValueInstance = ((long)currentValueValue);
                                        usageInstance.CurrentValue = currentValueInstance;
                                    }
                                    
                                    JToken limitValue = valueValue["limit"];
                                    if (limitValue != null && limitValue.Type != JTokenType.Null)
                                    {
                                        long limitInstance = ((long)limitValue);
                                        usageInstance.Limit = limitInstance;
                                    }
                                    
                                    JToken nextResetTimeValue = valueValue["nextResetTime"];
                                    if (nextResetTimeValue != null && nextResetTimeValue.Type != JTokenType.Null)
                                    {
                                        string nextResetTimeInstance = ((string)nextResetTimeValue);
                                        usageInstance.NextResetTime = nextResetTimeInstance;
                                    }
                                    
                                    JToken quotaPeriodValue = valueValue["quotaPeriod"];
                                    if (quotaPeriodValue != null && quotaPeriodValue.Type != JTokenType.Null)
                                    {
                                        string quotaPeriodInstance = ((string)quotaPeriodValue);
                                        usageInstance.QuotaPeriod = quotaPeriodInstance;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
