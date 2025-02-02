/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegionSettings operation.
    /// Updates the current service opt-in settings for the Region. If service-opt-in is enabled
    /// for a service, Backup tries to protect that service's resources in this Region, when
    /// the resource is included in an on-demand backup or scheduled backup plan. Otherwise,
    /// Backup does not try to protect that service's resources in this Region. Use the <code>DescribeRegionSettings</code>
    /// API to determine the resource types that are supported.
    /// </summary>
    public partial class UpdateRegionSettingsRequest : AmazonBackupRequest
    {
        private Dictionary<string, bool> _resourceTypeOptInPreference = new Dictionary<string, bool>();

        /// <summary>
        /// Gets and sets the property ResourceTypeOptInPreference. 
        /// <para>
        /// Updates the list of services along with the opt-in preferences for the Region.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> ResourceTypeOptInPreference
        {
            get { return this._resourceTypeOptInPreference; }
            set { this._resourceTypeOptInPreference = value; }
        }

        // Check to see if ResourceTypeOptInPreference property is set
        internal bool IsSetResourceTypeOptInPreference()
        {
            return this._resourceTypeOptInPreference != null && this._resourceTypeOptInPreference.Count > 0; 
        }

    }
}