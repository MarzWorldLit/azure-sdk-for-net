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
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// AzureML Web Service linked service.
    /// </summary>
    public partial class AzureMLLinkedService : LinkedServiceProperties
    {
        private string _apiKey;
        
        /// <summary>
        /// Required. The API key for accessing the AzureML model endpoint.
        /// </summary>
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }
        
        private string _mlEndpoint;
        
        /// <summary>
        /// Required. The AzureML Web Service REST URL for requesting batch
        /// scoring.
        /// </summary>
        public string MlEndpoint
        {
            get { return this._mlEndpoint; }
            set { this._mlEndpoint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class.
        /// </summary>
        public AzureMLLinkedService()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class with
        /// required arguments.
        /// </summary>
        public AzureMLLinkedService(string mlEndpoint, string apiKey)
            : this()
        {
            if (mlEndpoint == null)
            {
                throw new ArgumentNullException("mlEndpoint");
            }
            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey");
            }
            this.MlEndpoint = mlEndpoint;
            this.ApiKey = apiKey;
        }
    }
}