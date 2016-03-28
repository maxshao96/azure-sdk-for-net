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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// HVR Azure failback input.
    /// </summary>
    public partial class RecoveryPlanHyperVReplicaAzureFailbackInput : RecoveryPlanProviderSpecificFailoverInput
    {
        private string _dataSyncOption;
        
        /// <summary>
        /// Required. Data sync option.
        /// </summary>
        public string DataSyncOption
        {
            get { return this._dataSyncOption; }
            set { this._dataSyncOption = value; }
        }
        
        private string _recoveryVmCreationOption;
        
        /// <summary>
        /// Required. Recovery VM creation option.
        /// </summary>
        public string RecoveryVmCreationOption
        {
            get { return this._recoveryVmCreationOption; }
            set { this._recoveryVmCreationOption = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailbackInput class.
        /// </summary>
        public RecoveryPlanHyperVReplicaAzureFailbackInput()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailbackInput class with required
        /// arguments.
        /// </summary>
        public RecoveryPlanHyperVReplicaAzureFailbackInput(string dataSyncOption, string recoveryVmCreationOption)
            : this()
        {
            if (dataSyncOption == null)
            {
                throw new ArgumentNullException("dataSyncOption");
            }
            if (recoveryVmCreationOption == null)
            {
                throw new ArgumentNullException("recoveryVmCreationOption");
            }
            this.DataSyncOption = dataSyncOption;
            this.RecoveryVmCreationOption = recoveryVmCreationOption;
        }
    }
}